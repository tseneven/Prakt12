using Prakt12.Data.Repositorys;
using Prakt12.Data.Repositorys.RoleRepository;
using Prakt12.Data.Repositorys.UserRepository;
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
        public User user { get; set; }
        public IUser_Repository _service { get; set; } = new User_Repository();
        public IRoleRepository role_servise { get; set; } = new Role_Repository();
        public Role role { get; set; } = new();
        bool isEdit = false;

        public AddPage()
        {
            if (user == null)
                user = new();
            InitializeComponent();
            Title.Content = "Добавление";
            Button.Content = "Добавить";
        }

        public AddPage(User curUser)
        {
            this.user = curUser;
            role = curUser.Role;    
            isEdit  = true;
            InitializeComponent();
            Title.Content = "Изменение";
            Button.Content = "Изменить";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            user.RoleId = role.Id;
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

        private void Page_Initialized(object sender, EventArgs e)
        {


        }
    }
}
