using Prakt12.Data.Repositorys;
using Prakt12.Models;
using System;
using System.Collections.Generic;
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

namespace Prakt12.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        public IUser_Repository service { get; set; } = new User_Repository();

        public User? user { get; set; } = null;


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Элемент не выбран");
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить?",
MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                service.DeleteUser(user);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Элемент не выбран");
                return;
            }
            NavigationService.Navigate(new AddPage(user));


        }
    }
}
