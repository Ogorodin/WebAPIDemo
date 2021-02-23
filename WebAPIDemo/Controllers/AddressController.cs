using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAPIDemo.Entity;
using WebAPIDemo.Repository;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("[address]")]
    public class AddressController : Controller
    {
        private IAddressRepository _addressRepository;

        public IActionResult Index()
        {
            return View();
        }

        // get all
        [HttpGet]
        public IEnumerable<List<Address>> Get()
        {
            throw new NotImplementedException();
        }

        // get by id
        public Address GetAddressById(string id)
        {
            throw new NotImplementedException();
        }

        // add
        public bool AddNewAddress(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
