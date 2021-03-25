using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<List<Address>> LoadAllAsync()
        {
            Console.WriteLine("AddressService implementation run trough API.Services.AddressService.LoadAll()");
            return await _addressRepository.LoadAllAsync();
        }

        public async Task<bool> AddAddressAsync(Address address)
        {
            Console.WriteLine("AddressService implementation run trough API.Services.AddressService.AddAddress()");

            if ( await _addressRepository.AddAddressAsync(address))
            {
                return true;
            }
            else
            {
                throw new Exception();
            }
        }

        public async Task<Address> GetAddressByIdAsync(string id)
        {
            Console.WriteLine("AddressService implementation run trough API.Services.AddressService.GetAddressById()");
            return await _addressRepository.GetAddressByIdAsync(id);
        }

        public async Task<bool> UpdateAddressAsync(string id, Address updatedAddress)
        {
            Console.WriteLine("AddressService implementation run trough API.Services.AddressService.UpdateAddress()");
            return await _addressRepository.UpdateAddressAsync(id, updatedAddress);
        }

        public async Task<bool> DeleteAddressAsync(string id)
        {
            Console.WriteLine("AddressService implementation run trough  API.Services.AddressService.DeleteAddress()");
            return await _addressRepository.DeleteAddressAsync(id);
        }
    }
}
