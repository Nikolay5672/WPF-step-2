using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    public class UserService
    {
        private static List<User> _users;

        public UserService()
        {
            _users = new List<User>()
            {
                new User() { Id = 1, FirstName = "Bob", LastName = "Stanley", Role = "teacher" },
                new User() { Id = 2, FirstName = "Alice", LastName = "Johnson", Role = "student" },
                new User() { Id = 3, FirstName = "John", LastName = "Doe", Role = "admin" }
                // Add more users as needed
            };

        }

        public List<User> GetAll()
        {
            return _users;
        }

        public bool Add(User user)
        {
            _users.Add(user);
            return true;
        }

        public bool Update(User user)
        {
            bool isUpdated = false;
            foreach (var currentUser in _users)
            {
                if (currentUser.Id == user.Id)
                {
                    currentUser.FirstName = user.FirstName;
                    currentUser.LastName = user.LastName;
                    currentUser.Role = user.Role;
                    // maybe id as well
                    isUpdated = true;
                    break;
                }
            }

            return isUpdated;
        }

        public bool Delete(int id)
        {
            bool isDeleted = false;
            foreach (var currentUser in _users)
            {
                if (currentUser.Id == id)
                {
                    _users.Remove(currentUser);
                    isDeleted = true;
                    break;
                }
            }


            return isDeleted;
        }

        public User GetUser(int id)
        {
            return _users.FirstOrDefault(e => e.Id == id);
        }
    }
}
    

