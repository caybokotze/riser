using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiserAPI.Data;
using RiserAPI.Models;

namespace RiserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseJumpController : Controller
    {
        private ApplicationDbContext _context;
        public BaseJumpController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.BaseJumps.ToList());
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id != null)
            {
                return Ok(_context.BaseJumps.Find(id));
            }

            return BadRequest();
        }

        [HttpPost]
        public IActionResult Post([FromBody] BaseJump baseJump)
        {
            if (!ModelState.IsValid) return BadRequest();
            _context.Add(baseJump);
            _context.SaveChanges();
            return Ok(baseJump);

        }

        [HttpPut]
        public IActionResult Put([FromBody] BaseJump baseJump)
        {
            if (!ModelState.IsValid) return BadRequest();
            _context.Entry(baseJump).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(baseJump);

        }

        [HttpDelete]
        public IActionResult Delete([FromBody] BaseJump baseJump)
        {
            if (!ModelState.IsValid) return BadRequest();
            _context.BaseJumps.Remove(baseJump);
            _context.SaveChanges();
            return Ok(baseJump);
        }
    }
}