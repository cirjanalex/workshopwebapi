using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkshopWebApi.Models;

namespace WorkshopWebApi.Controllers
{
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public IEnumerable<User> GetAllUsers()
        {
            return new List<User> () { new User() {Id = 0, Name = "Alex" }};
        }
    }
}