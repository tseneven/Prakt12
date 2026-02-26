using Prakt12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Data.Repositorys
{
    public interface IUser_Repository
    {
        public void Add(User user);
        public bool LoginIsExist(string Login);
        public bool EmailIsExist(string email);
        public void GetAll();
        public void DeleteUser(User user);
        public void UpdateUser();
    }
}
