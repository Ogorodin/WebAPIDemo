using System;
using System.Collections.Generic;
using DataLayer.Entity;
using DataLayer.Repository;

namespace APIDemo.Services
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
            Console.WriteLine("AddressService implementation run trough LoadAll()");
            return _addressRepository.LoadAll();
        }

        public bool AddAddress(Address address)
        {
            Console.WriteLine("AddressService implementation run trough AddAddress()");
            return _addressRepository.AddAddress(address);
        }

        public Address GetAddressById(string id)
        {
            Console.WriteLine("AddressService implementation run trough GetAddressById()");
            return _addressRepository.GetAddressById(id);
        }


    }
}
