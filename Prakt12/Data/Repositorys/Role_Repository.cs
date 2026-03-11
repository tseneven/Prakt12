using Microsoft.EntityFrameworkCore;
using Prakt12.Models;
using System.Collections.ObjectModel;


namespace Prakt12.Data.Repositorys
{
    public class Role_Repository : IRoleRepository
    {
        private readonly AppDBContext _db = Base_Repository.Instance.Context;

        public ObservableCollection<User> adminsList { get; set; } = new();
        public ObservableCollection<User> usersList { get; set; } = new();
        public ObservableCollection<User> menegersList { get; set; } = new();
        public Role_Repository()
        {
            GetAll();
        }

        public void GetAll()
        {
            adminsList.Clear();
            usersList.Clear();
            menegersList.Clear();

            var users = _db.Users.Include(U => U.userProfile).Where(u => u.RoleId == 1).ToList();
            foreach (var user in users)
            {
                usersList.Add(user);
            }

            var admins = _db.Users.Include(U => U.userProfile).Where(u => u.RoleId == 3).ToList();
            foreach (var user in admins)
            {
                adminsList.Add(user);
            }

            var menegers = _db.Users.Include(U => U.userProfile).Where(u => u.RoleId == 2).ToList();
            foreach (var user in menegers)
            {
                menegersList.Add(user);
            }
        }
    }
}
