using Prakt12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Data.Repositorys
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
