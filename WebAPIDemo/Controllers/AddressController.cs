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
        public List<Address> Get()
        {
            try
            {
                return _addressRepository.LoadAll();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception thrown in WebAPIDemo.Controllers.AddressController");
                return null;
            }

        }

        // get by id
        [HttpGet("{id}")]
        public Address GetAddressById(string id)
        {
            try
            {
                return _addressRepository.GetAddressById(id);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception thrown in WebAPIDemo.Controllers.AddressController");
                return null;
            }
        }

        // add
        [HttpPost]
        public bool AddNewAddress(Address address)
        {
            try
            {
                address.Id = Guid.NewGuid();
                Console.WriteLine(address.ToString());
                _addressRepository.AddAddress(address);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception thrown in WebAPIDemo.Controllers.AddressController");
                return false;
            };
        }
    }
}
