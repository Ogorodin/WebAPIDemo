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
            Console.WriteLine("AddressService implementation run trough API.Services.AddressService.LoadAll()");
            return _addressRepository.LoadAll();
        }

        public bool AddAddress(Address address)
        {
            Console.WriteLine("AddressService implementation run trough API.Services.AddressService.AddAddress()");

            if (_addressRepository.AddAddress(address))
            {
                return true;
            }
            else
            {
                throw new Exception();
            }
        }

        public Address GetAddressById(string id)
        {
            Console.WriteLine("AddressService implementation run trough API.Services.AddressService.GetAddressById()");
            return _addressRepository.GetAddressById(id);
        }

        public bool UpdateAddress(string id, Address updatedAddress)
        {
            Console.WriteLine("AddressService implementation run trough API.Services.AddressService.UpdateAddress()");
            return _addressRepository.UpdateAddress(id, updatedAddress);
        }

        public bool DeleteAddress(string id)
        {
            Console.WriteLine("AddressService implementation run trough  API.Services.AddressService.DeleteAddress()");
            return _addressRepository.DeleteAddress(id);
        }
    }
}
