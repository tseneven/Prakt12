using Prakt12.Data.Repositorys.GroupInterestRepository;
using Prakt12.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Prakt12.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public InterestGroup interestGroup { get; set; } = new InterestGroup();
        private readonly IGroupInterest_Repository servise = new GroupInterest_Repository();
        private bool isEdit = false;
        private bool isAccept = false;

        public AddGroupPage()
        {
            InitializeComponent();
        }

        public AddGroupPage(InterestGroup interestGroup)
        {
            this.interestGroup = interestGroup;
            InitializeComponent();
            isEdit = true;
            Title.Content = "Изменение";
            Button.Content = "Изменить";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (interestGroup != null && !string.IsNullOrEmpty(interestGroup.Title) && !string.IsNullOrEmpty(interestGroup.Description))
            {
                if (!isEdit)
                {
                    servise.AddInterstGroup(interestGroup);
                    MessageBox.Show("Группа создана");
                }
                else
                {
                    if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменить?",
    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        servise.UpdateInterstGroup();
                    }
                    MessageBox.Show("Группа изменена");
                }

                if (isAccept) NavigationService.GoBack();
            }
            else
                MessageBox.Show("Ошибка: Поля не могут быть пустыми");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
