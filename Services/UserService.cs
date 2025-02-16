using System.Threading.Tasks;

namespace EventEase.Services
{
    public class UserService
    {
        private User _currentUser;

        public User GetCurrentUser()
        {
            return _currentUser;
        }

        public Task Login(User user)
        {
            _currentUser = user;
            return Task.CompletedTask;
        }

        public Task Logout()
        {
            _currentUser = null;
            return Task.CompletedTask;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
