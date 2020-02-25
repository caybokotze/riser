using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RiserAPI.Data;

namespace RiserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JumpController : ControllerBase
    {
        private ApplicationDbContext _context;
        public JumpController()
        {
            _context = new ApplicationDbContext();
        }
        // GET
        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.Jumps.ToList());
        }
        
        public IActionResult Get(int? id)
        {
            if (id == null) return BadRequest();
            return Ok(_context.Jumps.Find(id));
        }
    }
}