using Prakt12.Data.Repositorys.GroupInterestRepository;
using Prakt12.Data.Repositorys.UserInterestGroupRepository;
using Prakt12.Data.Repositorys.UserRepository;
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
    /// Логика взаимодействия для AddUserToGroup.xaml
    /// </summary>
    public partial class AddUserToGroup : Page
    {
        public IUser_Repository userService {  get; set; } = new User_Repository();
        public IGroupInterest_Repository groupService { get; set; } = new GroupInterest_Repository();
        public UserInterestGroup UserInterestGroup { get; set; } = new();
        private readonly IUserInterestGroup_Repository service = new UserInterestGroup_Repository();
        public AddUserToGroup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(isCurrentData.IsChecked == true)
                UserInterestGroup.JoinedAt = DateTime.Now;
            else 
                if(Date.SelectedDate != null)
                    UserInterestGroup.JoinedAt = Date.SelectedDate.Value;

            UserInterestGroup.UserId = UserInterestGroup.User.Id;
            UserInterestGroup.InterestGroupId = UserInterestGroup.InterestGroup.Id;
            if (UserInterestGroup.User != null && UserInterestGroup.InterestGroup != null)
            {
                service.Add(UserInterestGroup);
                NavigationService.GoBack();
            }
            else
                MessageBox.Show("Ошибка: не выбрана группа или пользователь");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
