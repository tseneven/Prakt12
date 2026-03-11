using Prakt12.Data.Repositorys;
using Prakt12.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Prakt12.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public User? _currentUser { get; set; } = null;
        bool isEdit = false;
        private IUserProfile_Repository _service = new UserProfile_Repository();

        public ProfilePage(User user)
        {
            if (user == null)
            {
                MessageBox.Show("пользователь == null");
                return;
            }
            _currentUser = user;
            DataContext = _currentUser.userProfile;
            InitializeComponent();
        }

        private void Page_Initialized(object sender, EventArgs e)
        {
            DatePickerDate.IsEnabled = false;
            BioTextBox.IsEnabled = false;
            PhoneTextBox.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(isEdit == true)
            {
                DatePickerDate.IsEnabled = false;
                BioTextBox.IsEnabled = false;
                PhoneTextBox.IsEnabled = false;
                editBtn.Content = "Редактировать";
                _service.updateProfile();
                MessageBox.Show("Информация обновлена!");
                isEdit = false;
           
            }
            else
            {
                DatePickerDate.IsEnabled = true;
                BioTextBox.IsEnabled = true;
                PhoneTextBox.IsEnabled = true;
                editBtn.Content = "Сохранить";
                isEdit = true;
            }
        }
        
    }
}
