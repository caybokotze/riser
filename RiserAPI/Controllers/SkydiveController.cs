using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiserAPI.Data;

namespace RiserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkydiveController : Controller
    {
        private ApplicationDbContext _context;
        public SkydiveController()
        {
            _context = new ApplicationDbContext();
        }
        
        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.Skydives.ToList());
        }

        [HttpGet]
        [Route("user")]
        public IActionResult GetUserSkydives(string userId)
        {
            if (userId == null) return BadRequest();
            return Ok(_context.Skydives
                .Include(i => i.Jump)
                .Where(w => w.Jump.UserId == userId));
        }

        [HttpGet]
        [Route("jump")]
        public IActionResult GetJumpSkydives(int? jumpId)
        {
            if (jumpId == null) return BadRequest();
            return Ok(_context.Skydives.Where(w => w.JumpId == jumpId));
        }
    }
}