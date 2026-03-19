using Prakt12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Data.Repositorys.UserInterestGroupRepository
{
    public interface IUserInterestGroup_Repository
    {
        public void Add(UserInterestGroup userInterestGroup);
        public void GetAll();
        public void GetByGroupID(InterestGroup interestGroup);
        public void GetByUserID(User user);

    }
}
