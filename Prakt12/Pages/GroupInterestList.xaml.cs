using Prakt12.Data.Repositorys.GroupInterestRepository;
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
    /// Логика взаимодействия для GroupInterestList.xaml
    /// </summary>
    public partial class GroupInterestList : Page
    {
        public InterestGroup InterestGroup { get; set; } = new();
        public IGroupInterest_Repository servise { get; set; } = new GroupInterest_Repository();
        public GroupInterestList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddGroupPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (InterestGroup != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить?",
    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    servise.DeleteInterstGroup(InterestGroup);
                }

            }
            else
                MessageBox.Show("Ошибка: Группа не выбрана");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddGroupPage(InterestGroup));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddUserToGroup());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                InterestGroup data = item.DataContext as InterestGroup;
                NavigationService.Navigate(new GroupInfo(data));
            }
        }
        //Я когда-нибудь научусь в нейминг элементов в wpf

    }
}
