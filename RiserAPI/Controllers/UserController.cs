using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiserAPI.Models;
using RiserAPI.Models.User;

namespace RiserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            IEnumerable<User> users = new[]
            {
                new User
                {
                    Name = "Jessica",
                    Surname = "De Villiers",
                    Email = "jess@gmail.com",
                    Dob = DateTime.Parse("1996-06-25", new CultureInfo(1))
                },
                new User
                {
                    Name = "Caybo",
                    Surname = "Kotze",
                    Email = "caybo@gmail.com",
                    Dob = DateTime.Parse("1996-06-25", new CultureInfo(1))
                }
            };

            return users;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
