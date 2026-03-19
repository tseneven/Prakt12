using Prakt12.Data.Repositorys;
using Prakt12.Data.Repositorys.UserRepository;
using Prakt12.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Элемент не выбран");
                return;
            }

            if(user.userProfile != null)
            {
                NavigationService.Navigate(new ProfilePage(user));
            }
            else
            {
                NavigationService.Navigate(new AddProfile(user));

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RoleUsers());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GroupInterestList());
        }
    }
}
