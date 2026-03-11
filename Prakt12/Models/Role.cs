using Prakt12.Data.Utils;
using System.Collections.ObjectModel;


namespace Prakt12.Models
{
    public class Role : ObservableObject
    {
        private int _id;
        private string _title;
        private ObservableCollection<User> _users;

        public int Id { get => _id; set => SetProperty(ref _id, value); }
        public string Title { get => _title; set => SetProperty(ref _title, value); }
        public ObservableCollection<User> Users { get => _users; set => SetProperty(ref _users, value); }
    }
}
