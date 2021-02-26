using APIDemo.Services;
using DataLayer.Entity;
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
                    return StatusCode(200, list);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in API.Controllers.UserController.LoadAllUsers()");
                return StatusCode(500, exc.StackTrace);
            }
        }

        // find by id
        [HttpGet]
        public IActionResult FindUserById(string id)
        {
            try
            {
                var user = _userService.FindById(id);
                if (user != null)
                {
                    return StatusCode(200, user);
                }
                else
                {
                    return StatusCode(404);
                }
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
                    return StatusCode(200);
                }
                return StatusCode(404);
            }
            catch (Exception exc) // handle again
            {
                Console.WriteLine("Exception caught in API.Controllers.UserController.AddUser()");
                return StatusCode(500, exc.StackTrace);
            }
        }
        // delete user
        [HttpDelete]
        public IActionResult DeleteUser(string id)
        {
            try
            {
                if (_userService.DeleteUser(id))
                {
                    return StatusCode(200);
                }
                return StatusCode(404);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in API.Controllers.UserController.DeleteUser()");
                return StatusCode(500, exc.StackTrace);
            }
        }

        // update user
        [HttpPost("{id}")]
        public IActionResult UpdateUser(string id, User updatedUser)
        {
            try
            {
                if (_userService.UpdateUser(id, updatedUser))
                {
                    return StatusCode(200, updatedUser);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception caught in API.Controllers.UserController.UpdateUser()");
                return StatusCode(500, exc.StackTrace);
            }
        }
    }
}



