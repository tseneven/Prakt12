using Prakt12.Data.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Models
{
    public class UserProfile : ObservableObject
    {
        private int _id;

        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string? _urlAvatar;
        public string? UrlAvatar
        {
            get => _urlAvatar;
            set => SetProperty(ref _urlAvatar, value);
        }

        private string _phone;
        public string Phone
        {
            get => _phone;
            set => SetProperty(ref _phone, value);
        }
        private DateTime _birthday;
        public DateTime Birthday
        {
            get => _birthday;
            set => SetProperty(ref _birthday, value);
        }

        private string _bio;
        public string Bio
        {
            get => _bio;
            set => SetProperty(ref _bio, value);
        }

        private int _userId;
        public int UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }

        private User _user;
        public User user
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }
    }
}
