using Prakt12.Data.Repositorys;
using Prakt12.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Prakt12.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public User user = new();
        private IUser_Repository _service = new User_Repository();
        bool isEdit = false;

        public AddPage()
        {
            InitializeComponent();
            DataContext = user;
            Title.Content = "Добавление";
            Button.Content = "Добавить";
        }

        public AddPage(User user)
        {
            InitializeComponent();
            DataContext = user;
            Title.Content = "Изменение";
            isEdit = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (!isEdit)
            {
                if (String.IsNullOrEmpty(user.Login)
&& String.IsNullOrEmpty(user.Name)
&& String.IsNullOrEmpty(user.Email)
&& String.IsNullOrEmpty(user.Password)
)
                {
                    MessageBox.Show("Не все поля заполнены!");
                }
                else
                {
                    _service.Add(user);
                }
            }
            else
            {
                _service.UpdateUser();
            }
            NavigationService.GoBack();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
