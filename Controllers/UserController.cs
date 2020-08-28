using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkshopWebApi.Models;
using WorkshopWebApi.Providers;

namespace WorkshopWebApi.Controllers
{
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserProvider userProvider;

        public UsersController(IUserProvider userProvider)
        {
            this.userProvider = userProvider;
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return userProvider.GetAll();
        }
        
        [HttpGet]
        [Route("{id}")]
        public User GetUser(int id)
        {
            return userProvider.GetById(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public IEnumerable<User> DeleteUser(int id)
        {
            userProvider.DeleteUser(id);
            return userProvider.GetAll();
        }

        [HttpPost]
        public void AddUser([FromBody] User user)
        {
            userProvider.AddUser(user);        
        }

        [HttpPost]
        [Route("{id}")]
        public void ModifyUser(int id, [FromBody] User user)
        {
            userProvider.UpdateUser(id, user);
        }
    }
}