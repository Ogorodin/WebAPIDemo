using DataLayer.Entity;
using DataLayer.Repository;
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
            Console.WriteLine("UserService implementation run trough  API.Services.UserService.LoadAllUsers()");
            return _userRepository.LoadAllUsers();
        }
        public User FindById(string id)
        {
            Console.WriteLine("UserService implementation run trough  API.Services.UserService.FindById()");
            return _userRepository.FindById(id);
        }

        public bool AddUser(User user)
        {
            Console.WriteLine("UserService implementation run trough  API.Services.UserService.AddUser()");
            return _userRepository.AddUser(user);
        }

        public bool DeleteUser(string id)
        {
            Console.WriteLine("UserService implementation run trough  API.Services.UserService.DeleteUser()");
            return _userRepository.DeleteUser(id);
        }

        public bool UpdateUser(string id, User updatedUser)
        {
            Console.WriteLine("UserService implementation run trough API.Services.UserService.UpdateUser()");
            return _userRepository.UpdateUser(id, updatedUser);
        }
    }
}
