using Microsoft.EntityFrameworkCore;
using Prakt12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prakt12.Data.Repositorys.UserInterestGroupRepository
{
    public class UserInterestGroup_Repository : IUserInterestGroup_Repository
    {
        private readonly AppDBContext _db = Base_Repository.Instance.Context;

        public ObservableCollection<UserInterestGroup> userInterestGroups { get; set; } = new();

        public void Add(UserInterestGroup userInterestGroup)
        {
            var _userInterestGroup = new UserInterestGroup
            {
                UserId = userInterestGroup.UserId,
                InterestGroupId = userInterestGroup.InterestGroupId,
                IsModerator = userInterestGroup.IsModerator,
                JoinedAt = userInterestGroup.JoinedAt,
                User = userInterestGroup.User,
                InterestGroup = userInterestGroup.InterestGroup
            };

            _db.UserInterestGroups.Add(userInterestGroup);
            Commit();
        }
        public void GetAll()
        {
            userInterestGroups.Clear();
            var _userInterestGroups = _db.UserInterestGroups
                .Include(c => c.User)
                .Include(c => c.InterestGroup)
                .ToList();
            foreach (UserInterestGroup userInterestGroup in _userInterestGroups)
            {
                userInterestGroups.Add(userInterestGroup);
            }
        }

        public int Commit() => _db.SaveChanges();

        public void GetByGroupID(InterestGroup interestGroup)
        {
            userInterestGroups.Clear();
            var _userInterestGroups = _db.UserInterestGroups
                .Include(c => c.User)
                .Include(c => c.InterestGroup)
                .Where(c => c.InterestGroupId == interestGroup.Id)
                .ToList();
            foreach (UserInterestGroup userInterestGroup in _userInterestGroups)
            {
                userInterestGroups.Add(userInterestGroup);
            }
        }

        public void GetByUserID(User user)
        {
            userInterestGroups.Clear();
            var _userInterestGroups = _db.UserInterestGroups
                .Include(c => c.User)
                .Include(c => c.InterestGroup)
                .Where(c => c.UserId == user.Id)
                .ToList();
            foreach (UserInterestGroup userInterestGroup in _userInterestGroups)
            {
                userInterestGroups.Add(userInterestGroup);
            }
        }
    }
}
