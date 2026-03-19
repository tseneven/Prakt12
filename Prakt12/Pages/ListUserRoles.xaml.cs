using Prakt12.Data.Repositorys;
using Prakt12.Data.Repositorys.RoleRepository;
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
    /// Логика взаимодействия для ListUserRoles.xaml
    /// </summary>
    public partial class ListUserRoles : Page
    {
        public IRoleRepository service { get; set; } = new Role_Repository();

        public ListUserRoles(string title)
        {
            InitializeComponent();
            service.GetAll(title);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
