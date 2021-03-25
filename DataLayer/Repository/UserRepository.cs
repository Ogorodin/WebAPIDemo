using DataLayer.Entity;
using Domain;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<List<User>> LoadAllUsersAsync()
        {
            try
            {
                return await _userCollection.AsQueryable().ToListAsync();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.LoadAllUsers()");
                throw new DataLayerException("Something went wrong in the database.", exc);
            }
        }

        public async Task<User> FindByIdAsync(string id)
        {
            try
            {
                return (User)await _userCollection.FindAsync(user => user.Id == Guid.Parse(id));
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.FindById");
                throw new DataLayerException("Something went wrong in the database.", exc);
            }
        }

        public async Task<bool> AddUserAsync(User user)
        {
            try
            {
                await _userCollection.InsertOneAsync(user);
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.AddUser", exc.StackTrace);
                throw new DataLayerException("Something went wrong in the database.", exc);
            }
        }

        public async Task<bool> UpdateUserAsync(string id, User updatedUser)
        {
            try
            {
              await  _userCollection.FindOneAndReplaceAsync(user => user.Id == Guid.Parse(id), updatedUser);
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in DataLayer.Repository.UserRepository.UpdateUser", exc.StackTrace);
                throw new DataLayerException("Something went wrong in the database.", exc);
            }

        }
        public async Task<bool> DeleteUserAsync(string id)
        {
            try
            {
               await _userCollection.DeleteOneAsync(user => user.Id == Guid.Parse(id));
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
