using Prakt12.Data.Repositorys;
using Prakt12.Data.Repositorys.RoleRepository;
using Prakt12.Models;
using System.Windows.Controls;

namespace Prakt12.Pages
{
    /// <summary>
    /// Логика взаимодействия для RoleUsers.xaml
    /// </summary>
    public partial class RoleUsers : Page
    {
        public IRoleRepository service { get; set; } = new Role_Repository();
        public Role role { get; set; } = new();

        public RoleUsers()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


        private void ListView_Selected_1(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new ListUserRoles(role.Title));
        }
    }
}
