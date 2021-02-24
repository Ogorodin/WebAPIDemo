using System.Collections.Generic;
using WebAPIDemo.Entity;

namespace WebAPIDemo.Services
{
    public interface IAddressService
    {
        public List<Address> LoadAll();
        public Address GetAddressById(string id);
        public bool AddAddress(Address address);
    }
}
