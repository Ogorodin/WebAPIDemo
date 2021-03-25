using DataLayer.Entity;
using Domain;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IMongoCollection<Address> _addressCollection;

        public AddressRepository()
        {
            MongoClient client = new MongoClient();
            IMongoDatabase db = client.GetDatabase(Constants.DatabaseName);
            _addressCollection = db.GetCollection<Address>(Constants.CollectionName_address);
        }

        public async Task<List<Address>> LoadAllAsync()
        {
            try
            {
                return await _addressCollection.AsQueryable().ToListAsync();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in WebAPIDemo.Repository.AddressRepository.LoadAll");
                return null;
            }
        }

        public async Task<Address> GetAddressByIdAsync(string id)
        {
            try
            {
                return (Address)await _addressCollection.FindAsync(address => address.Id == Guid.Parse(id));
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in WebAPIDemo.Repository.AddressRepository.GetAddressById");
                return null;
            }
        }

        public async Task<bool> AddAddressAsync(Address address)
        {
            try
            {
                await _addressCollection.InsertOneAsync(address);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in WebAPIDemo.Repository.AddressRepository.AddAddress");
                return false;
            }
        }

        public async Task<bool> UpdateAddressAsync(string id, Address address)
        {
            try
            {
                await _addressCollection.FindOneAndReplaceAsync(address => address.Id == Guid.Parse(id), address);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in WebAPIDemo.Repository.AddressRepository.UpdateAddress");
                return false;
            }
        }

        public async Task<bool> DeleteAddressAsync(string id)
        {
            try
            {
                await _addressCollection.DeleteOneAsync(address => address.Id == Guid.Parse(id));
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in WebAPIDemo.Repository.AddressRepository.DeleteAddress");
                return false;
            }
        }
    }
}
