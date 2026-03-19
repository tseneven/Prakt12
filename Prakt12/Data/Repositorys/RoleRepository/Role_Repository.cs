using Microsoft.EntityFrameworkCore;
using Prakt12.Models;
using System.Collections.ObjectModel;


namespace Prakt12.Data.Repositorys.RoleRepository
{
    public class Role_Repository : IRoleRepository
    {
        private readonly AppDBContext _db = Base_Repository.Instance.Context;

        public ObservableCollection<User> usersList { get; set; } = new();
        public ObservableCollection<Role> roleList { get; set; } = new();

        public Role_Repository()
        {
            GetAllRoles();
        }

        public void GetAll(string title)
        {
            usersList.Clear();

            var users = _db.Users.Include(U => U.userProfile).Where(u => u.Role.Title == title).ToList();
            foreach (var user in users)
            {
                usersList.Add(user);
            }
        }

        public void GetAllRoles()
        {
            roleList.Clear();

            var roles = _db.Roles.ToList();
            foreach (var role in roles)
            {
                roleList.Add(role);
            }
        }
    }
}
