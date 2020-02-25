using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RiserAPI.Data;

namespace RiserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        private ApplicationDbContext _context;
        public ImageController()
        {
            _context = new ApplicationDbContext();
        }
    
        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.Images.ToList());
        }

        //Get gear images for a specific user.
        [HttpGet]
        [Route("usergear")]
        public IActionResult GetUserImages(string userId)
        {
            if (userId == null) return BadRequest();
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            return Ok(_context.Images.Find(id));
        }
        
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            _context.Remove(_context.Images.Find(id));
            _context.SaveChanges();
            return Ok();
        }
        
    }
}