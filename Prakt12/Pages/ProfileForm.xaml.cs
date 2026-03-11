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
    /// Логика взаимодействия для ProfileForm.xaml
    /// </summary>
    public partial class ProfileForm : Page
    {
        public UserProfile? userProfile { get; set; } = new();
        private User currUser;
        private IUserProfile_Repository _service = new UserProfile_Repository();

        public ProfileForm(User user)
        {
            InitializeComponent();
            DataContext = userProfile;
            currUser = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userProfile.UserId = currUser.Id;
            _service.addProfile(userProfile);
            NavigationService.Navigate(new MainPage());
        }
    }
}
