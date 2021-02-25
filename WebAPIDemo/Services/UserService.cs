using DataLayer.Entity;
using DataLayer.Repository;
using System;

namespace APIDemo.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User FindById(string id)
        {
            Console.WriteLine("UserService implementation run trough FindById()");
            return _userRepository.FindById(id);
        }

        public bool AddUser(User user)
        {
            Console.WriteLine("UserService implementation run trough AddUser()");
            return _userRepository.AddUser(user);
        }

        public bool DeleteUser(string id)
        {
            Console.WriteLine("UserService implementation run trough DeleteUser()");
            return _userRepository.DeleteUser(id);
        }

        public bool UpdateUser(string id, User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
