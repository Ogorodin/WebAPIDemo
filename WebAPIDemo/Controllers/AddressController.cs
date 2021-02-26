using DataLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using APIDemo.Services;
using Domain;
using Domain.Exceptions;

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
        public IActionResult GetAll()
        {
            try
            {
                List<Address> addressList = _addressService.LoadAll();
                if (addressList != null)
                {
                    return StatusCode(200, addressList);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (DataLayerException)
            {
                return StatusCode(500);
            }
            catch (UserServiceException)
            {
                return StatusCode(500);
            }
            catch (Exception exc)
            {
                return StatusCode(500, exc.StackTrace);
            }
        }

        // get by id
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAddressById(string id)
        {
            try
            {
                Address address = _addressService.GetAddressById(id);
                if (address != null)
                {
                    return StatusCode(200, address);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (DataLayerException)
            {
                return StatusCode(500);
            }
            catch (UserServiceException)
            {
                return StatusCode(500);
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
                _addressService.AddAddress(address);
                return StatusCode(200);
            }
            catch (DataLayerException)
            {
                return StatusCode(500);
            }
            catch (UserServiceException)
            {
                return StatusCode(500);
            }
            catch (Exception)
            {
                return StatusCode(500);
            };
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteAddress(string id)
        {
            try
            {
                if (_addressService.DeleteAddress(id))
                {
                    return StatusCode(202);
                }
                return StatusCode(404);
            }
            catch (DataLayerException)
            {
                return StatusCode(500);
            }
            catch (UserServiceException)
            {
                return StatusCode(500);
            }
            catch (Exception exc)
            {
                return StatusCode(500, exc.StackTrace);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateAddress(string id, Address address)
        {
            try
            {
                if (_addressService.UpdateAddress(id, address))
                {
                    return StatusCode(200);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (DataLayerException)
            {
                return StatusCode(500);
            }
            catch (UserServiceException)
            {
                return StatusCode(500);
            }
            catch (Exception exc)
            {
                return StatusCode(500, exc.StackTrace);
            }
        }
    }
}
