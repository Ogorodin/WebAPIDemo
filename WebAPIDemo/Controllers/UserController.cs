using APIDemo.Services;
using DataLayer.Entity;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading.Tasks;

namespace APIDemo.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : Controller
    {
        private IUserService _userService;
        private IMessageService _messageService;

        public UserController(IUserService userService, IMessageService messageService)
        {
            _userService = userService;
            _messageService = messageService;
        }

        [HttpGet]
        public async Task<IActionResult> LoadAllUsersAsync()
        {

            var list = await _userService.LoadAllUsersAsync();
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
        public async Task<IActionResult> FindUserByIdAsync(string id)
        {
            var user = await _userService.FindByIdAsync(id);
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
        public async Task<IActionResult> AddUserAsync(User user)
        {
            Guid id = Guid.NewGuid();
            user.Id = id;
            if (await _userService.AddUserAsync(user))
            {
                try
                {
                    _messageService.NotifyRabbit(user.Username, user.Email);
                }
                catch
                {
                    return NotFound();
                }
                return Ok();
            }
            return NotFound();

        }
        // delete user
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUserAsync(string id)
        {

            if (await _userService.DeleteUserAsync(id))
            {
                return Ok();
            }
            return NotFound();

        }

        // update user
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUserAsync(string id, User updatedUser)
        {

            if (await _userService.UpdateUserAsync(id, updatedUser))
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





