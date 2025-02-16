using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
    public class UserService
    {
        private User _currentUser;

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

        public User GetCurrentUser()
        {
            return _currentUser;
        }

        public bool IsUserLoggedIn()
        {
            return _currentUser != null;
        }
    }
}
