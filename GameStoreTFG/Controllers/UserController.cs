using System;
using System.Collections.Generic;
using GameStoreTFG.Model;
using GameStoreTFG.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiGames.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<controller>
        [HttpGet]
        public List<UserModel> GetUsers()
        {
            return _userService.GetUsers();
        }

        // GET api/<controller>/5
        [HttpGet("{id}", Name = "GetUserInfo")]
        public UserModel Get(Guid id)
        {
            return _userService.GetUserInfo(id);
        }

        // POST api/<controller>
        [HttpPost]
        public UserModel Post([FromBody]UserModel user)
        {
            return _userService.AddUser(user);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public UserModel Put(Guid id, [FromBody]UserModel user)
        {
            return _userService.UpdateUser(id, user);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return _userService.DropUser(id);
        }
    }
}
