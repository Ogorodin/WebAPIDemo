using DataLayer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIDemo.Services
{
    public interface IUserService
    {
        public Task<List<User>> LoadAllUsersAsync();
        public Task<User> FindByIdAsync(string id);
        public Task<bool> AddUserAsync(User user);
        public Task<bool> UpdateUserAsync(string id, User updatedUser);
        public Task<bool> DeleteUserAsync(string id);
    }
}
