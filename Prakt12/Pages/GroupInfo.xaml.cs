using Prakt12.Data.Repositorys.GroupInterestRepository;
using Prakt12.Data.Repositorys.UserInterestGroupRepository;
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
    /// Логика взаимодействия для GroupInfo.xaml
    /// </summary>
    public partial class GroupInfo : Page
    {
        public IUserInterestGroup_Repository service { get; set; } = new UserInterestGroup_Repository();
        public InterestGroup interestGroup { get; set; }
        public GroupInfo(InterestGroup interestGroup)
        {
            this.interestGroup = interestGroup;
            InitializeComponent();
            service.GetByGroupID(interestGroup);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); 
        }
    }
}
