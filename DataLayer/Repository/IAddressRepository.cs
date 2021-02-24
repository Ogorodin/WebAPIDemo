using DataLayer.Entity;
using System.Collections.Generic;

namespace DataLayer.Repository
{
    public interface IAddressRepository
    {
        public List<Address> LoadAll();
        public Address GetAddressById(string id);
        public bool AddAddress(Address address);
    }
}
