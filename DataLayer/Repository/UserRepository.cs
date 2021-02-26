using DataLayer.Entity;
using Domain;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
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

        public List<User> LoadAllUsers()
        {
            try
            {
                return _userCollection.AsQueryable().ToList();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.LoadAllUsers()");
                throw new DataLayerException("Something went wrong in the database.", exc);
            }
        }

        public User FindById(string id)
        {
            try
            {
                return _userCollection.Find(user => user.Id == Guid.Parse(id)).FirstOrDefault();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.FindById");
                throw new DataLayerException("Something went wrong in the database.", exc);
            }
        }

        public bool AddUser(User user)
        {
            try
            {
                _userCollection.InsertOne(user);
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.AddUser", exc.StackTrace);
                throw new DataLayerException("Something went wrong in the database.", exc);
            }
        }

        public bool UpdateUser(string id, User updatedUser)
        {
            try
            {
                _userCollection.FindOneAndReplace(user => user.Id == Guid.Parse(id), updatedUser);
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.UpdateUser", exc.StackTrace);
                throw new DataLayerException("Something went wrong in the database.", exc);
            }

        }
        public bool DeleteUser(string id)
        {
            try
            {
                _userCollection.DeleteOne(user => user.Id == Guid.Parse(id));
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.DeleteUser()", exc.StackTrace);
                throw new DataLayerException("Something went wrong in the database.", exc);
            }

        }
    }
}
