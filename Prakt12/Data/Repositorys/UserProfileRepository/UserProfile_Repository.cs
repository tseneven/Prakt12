using Prakt12.Models;

namespace Prakt12.Data.Repositorys.UserProfileRepository
{
    public class UserProfile_Repository : IUserProfile_Repository
    {
        private readonly AppDBContext _db = Base_Repository.Instance.Context;

        public void addProfile(UserProfile profile)
        {
            var _profile = new UserProfile
            {
                Birthday = profile.Birthday,
                Bio = profile.Bio,
                Phone = profile.Phone,
                UrlAvatar = profile.UrlAvatar,
                UserId = profile.UserId,
            };
            _db.Profiles.Add(profile);
            Commit();
        }

        public void updateProfile()
        {
            Commit();
        }
        public int Commit() => _db.SaveChanges();
    }
}
