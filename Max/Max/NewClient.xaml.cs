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

    /// <summary>
    /// Логика взаимодействия для NewClient.xaml
    /// </summary>
    public partial class NewClient : Window, INotifyPropertyChanged
    {
        public AutoserviceMax CurrentClient { get; set; }

        public NewClient(AutoserviceMax Client)
        {
            InitializeComponent();
            this.DataContext = this;
            CurrentClient = Client;
        }

        private void Photo_Click(object sender, RoutedEventArgs e)
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
                CurrentClient.Photo = GetImageDialog.FileName.Substring(Environment.CurrentDirectory.Length + 1);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentClient"));
            }
        }

        private void Save_Click_1(object sender, RoutedEventArgs e)
        {
            // если запись новая, то добавляем ее в список
            if (CurrentClient.Id == 0)
                Core.DB.AutoserviceMax.Add(CurrentClient);
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
