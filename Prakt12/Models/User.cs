using Prakt12.Data.Utils;

namespace Prakt12.Models
{
    public class User : ObservableObject
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }
        private string _login;
        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private string _email;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        private string _createdAt;
        public string CreatedAt
        {
            get => _createdAt;
            set
            {
                _createdAt = DateTime.Now.ToString();
                SetProperty(ref _createdAt, value);
            }
        }

        private UserProfile? _userProfile;
        public UserProfile? userProfile
        {
            get => _userProfile;
            set => SetProperty(ref _userProfile, value);
        }

        private Role _role;
        public Role Role 
        { 
            get => _role; 
            set => SetProperty(ref _role, value); 
        }
        private int _roleId;
        public int RoleId
        {
            get => _roleId;
            set => SetProperty(ref _roleId, value);
        }

    }
}
