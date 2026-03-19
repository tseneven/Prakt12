using Prakt12.Models;

namespace Prakt12.Data.Repositorys.UserProfileRepository
{
    public interface IUserProfile_Repository
    {
        public void addProfile(UserProfile profile);
        public void updateProfile();
    }
}
