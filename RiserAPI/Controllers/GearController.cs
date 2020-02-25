using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using RiserAPI.Data;
using RiserAPI.Models;

namespace RiserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GearController : Controller
    {
        private ApplicationDbContext _context;
        public GearController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.Gears.ToList());
        }

        /* Get all the gear item for a specific user.*/
        [HttpGet]
        [Route("user")]
        public IActionResult Get(string userId)
        {
            if (userId == null) return BadRequest();
            return Ok(_context.Gears.SingleOrDefault(w => w.UserId.Equals(userId)));
        }

        [HttpGet]
        public IActionResult Post([FromBody] Gear gear)
        {
            if (!ModelState.IsValid) return BadRequest();
            _context.Gears.Add(gear);
            _context.SaveChanges();
            return Ok(gear);
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();
            _context.Remove(_context.Gears.Find(id));
            _context.SaveChanges();
            return Ok("Gear item deleted:" + id);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Gear gear)
        {
            if (!ModelState.IsValid) return BadRequest();
            _context.Entry(gear).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(gear);
        }
    }
}