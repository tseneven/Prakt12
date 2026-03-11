using Prakt12.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;


namespace Prakt12.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProfile.xaml
    /// </summary>
    public partial class AddProfile : Page
    {
        User user;
        public AddProfile(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfileForm(user));
        }
    }
}
