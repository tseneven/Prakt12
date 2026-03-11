using Prakt12.Data.Repositorys;
using System.Windows.Controls;

namespace Prakt12.Pages
{
    /// <summary>
    /// Логика взаимодействия для RoleUsers.xaml
    /// </summary>
    public partial class RoleUsers : Page
    {
        public IRoleRepository service { get; set; } = new Role_Repository();

        public RoleUsers()
        {
            InitializeComponent();
        }
    }
}
