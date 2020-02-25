using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RiserAPI.Data;

namespace RiserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RigController : Controller
    {
        private ApplicationDbContext _context;
        public RigController()
        {
            _context = new ApplicationDbContext();
        }
        
        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.Rigs.ToList());
        }

        [HttpGet]
        [Route("user")]
        public IActionResult GetUserRigs(string userId)
        {
            if (userId == null) return BadRequest();
            //Todo: Add User navigational property to Rig Table.
            return Ok();
        }
    }
}