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

        // find by id
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
        public IActionResult AddUser(User user)
        {
            try
            {
                Guid id = new Guid();
                user = new User
                {
                    Id = id,
                    FirstName = "Test Lik",
                    Email = "testlik@foo.bar",
                    Username = "TestUserName",
                    CreatedAt = DateTime.Now
                };
                if (_userService.AddUser(user))
                {
                    return StatusCode(200);
                }
                return StatusCode(404);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        // delete user
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
                return StatusCode(500, exc.StackTrace);
            }
        }

        // update user

    }
}



