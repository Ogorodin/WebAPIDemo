using DataLayer.Entity;
using DataLayer.Repository;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIDemo.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> LoadAllUsersAsync()
        {
            try
            {
                // Imagine some heavy implementation that can cause a problem... PLIP PLOP BLAM
                Console.WriteLine("UserService implementation run trough  API.Services.UserService.LoadAllUsers()");
            }
            catch (UserServiceException exc)
            {
                throw new UserServiceException("Something happened in the user service.", exc);
            }
            return await _userRepository.LoadAllUsersAsync();
        }
        public async Task<User> FindByIdAsync(string id)
        {
            try
            {
                // Imagine some heavy implementation that can cause a problem... PLIP PLOP BLAM
                Console.WriteLine("UserService implementation run trough  API.Services.UserService.FindById()");
            }
            catch (UserServiceException exc)
            {
                throw new UserServiceException("Something happened in the user service.", exc);
            }
            return await _userRepository.FindByIdAsync(id);
        }

        public async Task<bool> AddUserAsync(User user)
        {
            try
            {
                // Imagine some heavy implementation that can cause a problem... PLIP PLOP BLAM
                Console.WriteLine("UserService implementation run trough  API.Services.UserService.AddUser()");
            }
            catch (UserServiceException exc)
            {
                throw new UserServiceException("Something happened in the user service.", exc);
            }
            return await _userRepository.AddUserAsync(user);
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            try
            {
                // Imagine some heavy implementation that can cause a problem... PLIP PLOP BLAM
                Console.WriteLine("UserService implementation run trough  API.Services.UserService.DeleteUser()");
            }
            catch (UserServiceException exc)
            {
                throw new UserServiceException("Something happened in the user service.", exc);
            }
            return await _userRepository.DeleteUserAsync(id);
        }

        public async Task<bool> UpdateUserAsync(string id, User updatedUser)
        {
            try
            {
                // Imagine some heavy implementation that can cause a problem... PLIP PLOP BLAM
                Console.WriteLine("UserService implementation run trough  API.Services.UserService.UpdateUser()");
            }
            catch (UserServiceException exc)
            {
                throw new UserServiceException("Something happened in the user service.", exc);
            }
            return  await _userRepository.UpdateUserAsync(id, updatedUser);
        }
    }
}
