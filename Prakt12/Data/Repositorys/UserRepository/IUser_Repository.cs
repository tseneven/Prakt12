using Prakt12.Models;

namespace Prakt12.Data.Repositorys.UserRepository
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
