using Prakt12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Data.Repositorys
{
    public interface IUserProfile_Repository
    {
        public void addProfile(UserProfile profile);
        public void updateProfile();
    }
}
