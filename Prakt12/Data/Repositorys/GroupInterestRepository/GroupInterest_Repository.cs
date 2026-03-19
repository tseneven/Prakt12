using Prakt12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Data.Repositorys.GroupInterestRepository
{
    public class GroupInterest_Repository : IGroupInterest_Repository
    {
        private readonly AppDBContext _db = Base_Repository.Instance.Context;

        public ObservableCollection<InterestGroup> InterestGroups { get; set; } = new();
        public GroupInterest_Repository()
        {
            GetAll();
        }
        public void GetAll()
        {
            InterestGroups.Clear();
            var _interestGroups = _db.InterestGroups.ToList();
            foreach(InterestGroup interestGroup in _interestGroups)
            {
                InterestGroups.Add(interestGroup);
            }
        }

        public void AddInterstGroup(InterestGroup interestGroup)
        {
            var _interestGroup = new InterestGroup
            {
                Title = interestGroup.Title,
                Description = interestGroup.Description,
            };

            _db.InterestGroups.Add(interestGroup);
            Commit();

        }

        public void UpdateInterstGroup()
        {
            Commit();
        }

        public void DeleteInterstGroup(InterestGroup interestGroup)
        {
            _db.Remove(interestGroup);
            if (Commit() > 0)
                if (InterestGroups.Contains(interestGroup))
                    InterestGroups.Remove(interestGroup);

        }
        public bool GroupIsExist(string title)
        {
            title = title.Trim();
            bool result = _db.InterestGroups.Any(u => u.Title == title);
            return result;
        }

        public int Commit() => _db.SaveChanges();

    }
}
