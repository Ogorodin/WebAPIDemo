using DataLayer.Entity;
using DataLayer.Repository;
using Domain.Exceptions;
using System;
using System.Collections.Generic;

namespace APIDemo.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> LoadAllUsers()
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
            return _userRepository.LoadAllUsers();
        }
        public User FindById(string id)
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
            return _userRepository.FindById(id);
        }

        public bool AddUser(User user)
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
            return _userRepository.AddUser(user);
        }

        public bool DeleteUser(string id)
        {
            try
            {
                // Imagine some heavy implementation that can cause a problem... PLIP PLOP BLAM
                Console.WriteLine("UserService implementation run trough  API.Services.UserService.DeleteUser()");
            }catch(UserServiceException exc)
            {
                throw new UserServiceException("Something happened in the user service.", exc);
            }
            return _userRepository.DeleteUser(id);
        }

        public bool UpdateUser(string id, User updatedUser)
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
            return _userRepository.UpdateUser(id, updatedUser);
        }
    }
}
