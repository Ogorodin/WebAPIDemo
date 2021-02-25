using DataLayer.Entity;
using Domain;
using MongoDB.Driver;
using System;
using System.Linq;

namespace DataLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _userCollection;

        public UserRepository()
        {
            IMongoClient client = new MongoClient();
            IMongoDatabase db = client.GetDatabase(Constants.DatabaseName);
            _userCollection = db.GetCollection<User>(Constants.CollectionName_user);
        }

        public User FindById(string id)
        {
            try
            {
                return _userCollection.Find(user => user.Id == Guid.Parse(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.FindById");
                return null;
            }
        }
        public bool AddUser(User user)
        {
            try
            {
                _userCollection.InsertOne(user);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.AddUser");
                return false;
            }
        }
        public bool UpdateUser(string id, User updatedUser)
        {
            // not implemented
            return false;
        }
        public bool DeleteUser(string id)
        {
            Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.UpdateUser");
            return false;
        }




    }
}
