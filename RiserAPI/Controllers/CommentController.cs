using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using RiserAPI.Data;
using RiserAPI.Models;
using RiserAPI.Models.User;

namespace RiserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        private ApplicationDbContext _context;
        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [Route("all")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Comments.ToList());
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id != null)
            {
                return Ok(_context.Comments.Find(id));
            }

            return BadRequest();
        }
        
        [Route("user/{id}")]
        [HttpGet]
        public IActionResult GetUserComments(string userId)
        {
            if (userId != null)
            {
                return Ok( _context.Comments.Where(w => w.UserId.Equals(userId)).ToList());
            }
            //
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Comments.Add(comment);
            _context.SaveChanges();
            return Ok(comment);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Entry(comment).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(comment);
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                return Ok(_context.Comments.Find(id));
            }

            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Remove(comment);
            _context.SaveChanges();
            return Ok(comment);
        }
        
    }
}