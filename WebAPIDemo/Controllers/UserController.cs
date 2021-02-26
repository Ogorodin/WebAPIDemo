using APIDemo.Services;
using DataLayer.Entity;
using Domain;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace APIDemo.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult LoadAllUsers()
        {
            try
            {
                var list = _userService.LoadAllUsers();
                if (list != null)
                {
                    return Ok(list);
                }
                else
                {
                    return NotFound();
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

        // find by id
        [HttpGet]
        [Route("{id}")]
        public IActionResult FindUserById(string id)
        {
            try
            {
                var user = _userService.FindById(id);
                if (user != null)
                {
                    return Ok(user);
                }
                else
                {
                    return NotFound();
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
                Console.WriteLine("Exception caught in API.Controllers.UserController.FindUserById()");
                return StatusCode(500, exc.StackTrace);
            }
        }

        // add user
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            try
            {
                Guid id = Guid.NewGuid();
                user.Id = id;
                if (_userService.AddUser(user))
                {
                    return Ok();
                }
                return NotFound();
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
                Console.WriteLine("Exception caught in API.Controllers.UserController.AddUser()");
                return StatusCode(500, exc.StackTrace);
            }
        }
        // delete user
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteUser(string id)
        {
            try
            {
                if (_userService.DeleteUser(id))
                {
                    return Ok();
                }
                return NotFound();
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
                Console.WriteLine("Exception caught in API.Controllers.UserController.DeleteUser()");
                return StatusCode(500, exc.StackTrace);
            }
        }

        // update user
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateUser(string id, User updatedUser)
        {
            try
            {
                if (_userService.UpdateUser(id, updatedUser))
                {
                    return Ok(updatedUser);
                }
                else
                {
                    return NotFound();
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
                Console.WriteLine("Exception caught in API.Controllers.UserController.UpdateUser()");
                return StatusCode(500, exc.StackTrace);
            }
        }
    }
}



