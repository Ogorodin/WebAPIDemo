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




        // find by id
        [HttpGet]
        [Route("{id}")]
        public IActionResult FindUserById(string id)
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

        // add user
        [HttpPost]
        public IActionResult AddUser(User user)
        {

            Guid id = Guid.NewGuid();
            user.Id = id;
            if (_userService.AddUser(user))
            {
                return Ok();
            }
            return NotFound();

        }
        // delete user
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteUser(string id)
        {

            if (_userService.DeleteUser(id))
            {
                return Ok();
            }
            return NotFound();

        }

        // update user
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateUser(string id, User updatedUser)
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
    }
}





