using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Max
{
    public partial class Client
    {
        public string FullName
        {
            get
            {
                return FullName;
            }
        }
    }
    public partial class ContractsMax
    {
        public string StartTimeText
        {
            get
            {
                return Date.ToString("dd.MM.yyyy");
            }
            set
            {
                Regex regex = new Regex(@"(\d+)\.(\d+)\.(\d+)");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    try
                    {
                        Date = new DateTime(
                            Convert.ToInt32(match.Groups[3].Value),
                            Convert.ToInt32(match.Groups[2].Value),
                            Convert.ToInt32(match.Groups[1].Value)

                            );
                    }
                    catch
                    {
                        MessageBox.Show("Не верный формат даты/времени");
                    }
                }
                else
                {
                    MessageBox.Show("Не верный формат даты/времени");
                }
            }
        }
    }


    /// <summary>
    /// Логика взаимодействия для CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window, INotifyPropertyChanged
    {

        public List<AutoserviceMax> ClientList { get; set; }
        public List<RoleMax> RoleList { get; set; }
        public ContractsMax CurrentService { get; set; }
        


        public CreateWindow(ContractsMax Contract)
        {
            InitializeComponent();
            this.DataContext = this;
            CurrentService = Contract;
            RoleList = Core.DB.RoleMax.ToList();
            ClientList = Core.DB.AutoserviceMax.ToList();
        }


        private void GetImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog GetImageDialog = new OpenFileDialog
            {
                // задаем фильтр для выбираемых файлов
                // до символа "|" идет произвольный текст, а после него шаблоны файлов раздеренные точкой с запятой
                Filter = "Файлы изображений: (*.png, *.jpg)|*.png;*.jpg",
                // чтобы не искать по всему диску задаем начальный каталог
                InitialDirectory = Environment.CurrentDirectory
            };
            if (GetImageDialog.ShowDialog() == true)
            {
                // перед присвоением пути к картинке обрезаем начало строки, т.к. диалог возвращает полный путь
                // (тут конечно еще надо проверить есть ли в начале Environment.CurrentDirectory)
                CurrentService.Photo = GetImageDialog.FileName.Substring(Environment.CurrentDirectory.Length + 1);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentService"));
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // если запись новая, то добавляем ее в список
            if (CurrentService.Id == 0)
                Core.DB.ContractsMax.Add(CurrentService);
            // сохранение в БД
            try
            {
                Core.DB.SaveChanges();

            }
            catch
            {
            }
            DialogResult = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
