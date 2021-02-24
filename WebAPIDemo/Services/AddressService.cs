using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Entity;
using WebAPIDemo.Repository;

namespace WebAPIDemo.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public List<Address> LoadAll()
        {
            return _addressRepository.LoadAll();
        }
        public bool AddAddress(Address address)
        {
            return _addressRepository.AddAddress(address);
        }

        public Address GetAddressById(string id)
        {
            return _addressRepository.GetAddressById(id);
        }


    }
}
