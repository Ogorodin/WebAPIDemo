using DataLayer.Entity;

namespace APIDemo.Services
{
    public interface IUserService
    {
        public User FindById(string id);
        public bool AddUser(User user);
        public bool UpdateUser(string id, User updatedUser);
        public bool DeleteUser(string id);
    }
}
