using DataLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using APIDemo.Services;
using System.Threading.Tasks;

namespace APIDemo.Controllers
{
    [ApiController]
    [Route("address")]
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService service)
        {
            _addressService = service;
        }

        // get all
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Address> addressList = await _addressService.LoadAllAsync();
            if (addressList != null)
            {
                return StatusCode(200, addressList);
            }
            else
            {
                return StatusCode(404);
            }
        }

        // get by id
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAddressByIdAsync(string id)
        {
            Address address = await _addressService.GetAddressByIdAsync(id);
            if (address != null)
            {
                return StatusCode(200, address);
            }
            else
            {
                return StatusCode(404);
            }
        }

        // add
        [HttpPost]
        public async Task<IActionResult> AddNewAddressAsync(Address address)
        {
            address.Id = Guid.NewGuid();
            Console.WriteLine(address.ToString());
            await _addressService.AddAddressAsync(address);
            return StatusCode(200);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAddressAsync(string id)
        {

            if (await _addressService.DeleteAddressAsync(id))
            {
                return StatusCode(202);
            }
            return StatusCode(404);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateAddressAsync(string id, Address address)
        {
            if (await _addressService.UpdateAddressAsync(id, address))
            {
                return StatusCode(200);
            }
            else
            {
                return StatusCode(404);
            }
        }
    }
}
