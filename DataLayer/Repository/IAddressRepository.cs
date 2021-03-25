using DataLayer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IAddressRepository
    {
        public Task<List<Address>> LoadAllAsync();
        public Task<Address> GetAddressByIdAsync(string id);
        public Task<bool> AddAddressAsync(Address address);
        public Task<bool> UpdateAddressAsync(string id, Address address);
        public Task<bool> DeleteAddressAsync(string id);
    }
}
