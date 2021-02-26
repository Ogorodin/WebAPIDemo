using DataLayer.Entity;
using System.Collections.Generic;

namespace APIDemo.Services
{
    public interface IUserService
    {
        List<User> LoadAllUsers();
        public User FindById(string id);
        public bool AddUser(User user);
        public bool UpdateUser(string id, User updatedUser);
        public bool DeleteUser(string id);
    }
}
