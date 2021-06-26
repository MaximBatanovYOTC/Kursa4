using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Max
{
    public partial class AutoserviceMax
    {
        public Uri ImagePrev
        {
            get
            {
                var imageName = System.IO.Path.Combine(Environment.CurrentDirectory, Photo ?? "");
                return System.IO.File.Exists(imageName) ? new Uri(imageName) : new Uri("pack://application:,,,/Debug/img/Client1.png");
            }
        }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class ClientList : Window, INotifyPropertyChanged
    {
        private List<AutoserviceMax> _KlientiList;
        public event PropertyChangedEventHandler PropertyChanged;
        public List<AutoserviceMax> KlientiList
        {
            get
            {
                return _KlientiList;
            }
            set
            {
                _KlientiList = value;
            }
        }


        public ClientList()
        {
            InitializeComponent();
            this.DataContext = this;
            KlientiList = Core.DB.AutoserviceMax.ToList();
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
                var Ord = new AutoserviceMax();
                var NewClientWind = new NewClient(Ord);
                if ((bool)NewClientWind.ShowDialog())
                {
                    KlientiList = Core.DB.AutoserviceMax.ToList();
                    PropertyChanged(this, new PropertyChangedEventArgs("KlientiList"));;
                }
        }
        private void DelOrd_Click(object sender, RoutedEventArgs e)
        {
            if (!(ProductListView.SelectedItem is AutoserviceMax item))
            {
                MessageBox.Show("Нельзя удалять, нужно выбрать");
                return;
            }

            Core.DB.AutoserviceMax.Remove(item);
            Core.DB.SaveChanges();
            KlientiList = Core.DB.AutoserviceMax.ToList();
            PropertyChanged(this, new PropertyChangedEventArgs("KlientiList"));
        }


        private void EditOrder_Click(object sender, RoutedEventArgs e)
        {
            if (!(ProductListView.SelectedItem is AutoserviceMax SelectedClient))
            {
                MessageBox.Show("Нельзя изменять, нужно выбрать");
                return;
            }

            var EditOrderWindow = new NewClient(SelectedClient);
            if ((bool)EditOrderWindow.ShowDialog())
            {
                PropertyChanged(this, new PropertyChangedEventArgs("KlientiList")); ;
            }
        }

    }
}
