using Microsoft.EntityFrameworkCore;
using Prakt12.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace Prakt12.Data.Repositorys
{
    public class User_Repository : IUser_Repository
    {
        private readonly AppDBContext _db = Base_Repository.Instance.Context;

        public static ObservableCollection<User> Users { get; set; } = new();

        public User_Repository()
        {
            GetAll();
        }

        public void Add(User user)
        {
            var _user = new User
            {
                Login = user.Login,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                CreatedAt = DateTime.Now.ToString(),
                userProfile = null,
                RoleId = 1
            };

            if(LoginIsExist(_user.Login) && EmailIsExist(_user.Email))
            {
                MessageBox.Show("Такая запись уже есть");
                return;
            }

            _db.Add(_user);
            Commit();
            GetLastUsers();
        }

        public bool LoginIsExist(string login)
        {
            login       = login.Trim().ToLower();
            bool result = _db.Users.Any(u => u.Login == login);
            return result;
        }

        public bool EmailIsExist(string email)
        {
            email       = email.Trim().ToLower();
            bool result = _db.Users.Any(u => u.Email == email);
            return result;
        }


        public void DeleteUser(User user)
        {
            _db.Remove<User>(user);
            if(Commit() > 0)
                if(Users.Contains(user))
                    Users.Remove(user);
        }


        public void GetAll()
        {
            var users = _db.Users.Include(U => U.userProfile).Include(u => u.Role).ToList();
            Users.Clear();
            foreach (var user in users)
            {
                Users.Add(user);
            }
        }

        public void GetLastUsers()
        {
            if(Users.Count > 0)
            {
                int lastId = Users.Max((a) => a.Id);
                var users  = _db.Users.ToList().Where((a) => a.Id > lastId);
                foreach (var user in users)
                {
                    Users.Add(user);
                }

            }
            if(Users.Count == 0)
            {
                GetAll();
            }

        }

        public void UpdateUser()
        {
            Commit();
        }



        public int Commit() => _db.SaveChanges();
    }
}   
