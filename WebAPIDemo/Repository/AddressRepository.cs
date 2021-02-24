using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPIDemo.Entity;

namespace WebAPIDemo.Repository
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

        public List<Address> LoadAll()
        {
            try
            {
                return _addressCollection.AsQueryable().ToList();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in WebAPIDemo.Repository.AddressRepository.LoadAll");
                return null;
            }
        }

        public Address GetAddressById(string id)
        {
            try
            {
                return _addressCollection.Find(address => address.Id == Guid.Parse(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in WebAPIDemo.Repository.AddressRepository.GetAddressById");
                return null;
            }
        }

        public bool AddAddress(Address address)
        {
            try
            {
                _addressCollection.InsertOne(address);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught in WebAPIDemo.Repository.AddressRepository.AddAddress");
                return false;
            }
        }
    }
}
