using Prakt12.Data.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Models
{
    public class UserInterestGroup : ObservableObject
    {
        private int _userId;
        private User _user;
        private int _interestGroupId;
        private InterestGroup _interestGroup;
        private DateTime _joinedAt;
        private bool _isModerator;

        public int UserId 
        { 
            get => _userId; 
            set => SetProperty(ref _userId, value); 
        }
        public int InterestGroupId 
        { 
            get => _interestGroupId; 
            set => SetProperty(ref _interestGroupId, value); 
        }
        public DateTime JoinedAt 
        { 
            get => _joinedAt; 
            set => SetProperty(ref _joinedAt, value); 
        }
        public bool IsModerator 
        { 
            get => _isModerator; 
            set => SetProperty(ref _isModerator, value); 
        }
        public User User 
        { 
            get => _user; 
            set => SetProperty(ref _user, value); 
        }
        public InterestGroup InterestGroup 
        { 
            get => _interestGroup; 
            set => SetProperty(ref _interestGroup, value); 
        }

        public string IsModeratorText
        {
            get {
                return IsModerator == true ? "Модератор" : "Обычный пользовтель";
            }
        }
    }
}
