using DataLayer.Entity;

namespace DataLayer.Repository
{
    public interface IUserRepository
    {
        public User FindById(string id);
        public bool AddUser(User user);
        public bool UpdateUser(string id, User updatedUser);
        public bool DeleteUser(string id);
    }
}
