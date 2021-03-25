using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.Entity;

namespace APIDemo.Services
{
    public interface IAddressService
    {
        public Task<List<Address>> LoadAllAsync();
        public Task<Address> GetAddressByIdAsync(string id);
        public Task<bool> AddAddressAsync(Address address);
        public Task<bool> UpdateAddressAsync(string id, Address updatedAddress);
        public Task<bool> DeleteAddressAsync(string id);

    }
}
