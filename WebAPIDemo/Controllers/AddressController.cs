using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAPIDemo.Entity;
using WebAPIDemo.Repository;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("address")]
    public class AddressController : Controller
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController()
        {
            _addressRepository = new AddressRepository(Constants.DatabaseName);
        }

        // get all
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                List<Address> addressList = _addressRepository.LoadAll();
                if (addressList != null)
                {
                    return StatusCode(200, addressList);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (Exception exc)
            {
                return StatusCode(500, exc.StackTrace);
            }
        }

        // get by id
        [HttpGet("{id}")]
        public IActionResult GetAddressById(string id)
        {
            try
            {
                Address address = _addressRepository.GetAddressById(id);
                if (address != null)
                {
                    return StatusCode(200, address);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (Exception exc)
            {
                return StatusCode(500, exc.StackTrace);
            }
        }

        // add
        [HttpPost]
        public IActionResult AddNewAddress(Address address)
        {
            try
            {
                address.Id = Guid.NewGuid();
                Console.WriteLine(address.ToString());
                _addressRepository.AddAddress(address);
                return StatusCode(200);
            }
            catch (Exception)
            {
                return StatusCode(500);
            };
        }
    }
}
