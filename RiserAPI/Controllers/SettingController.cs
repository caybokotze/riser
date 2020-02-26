using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RiserAPI.Data;

namespace RiserAPI.Controllers
{
    [Route("api/[controller]")]
    public class SettingController : Controller
    {
        private ApplicationDbContext _context;
        public SettingController()
        {
            _context = new ApplicationDbContext();
        }
        
        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.Settings.ToList());
        }
        
        [HttpGet]
        [Route("user")]
        public IActionResult GetUserSettings(int? userId)
        {
            if (userId == null) return BadRequest();
            return Ok(_context.Settings.Where(w => w.User.Id == userId));
        }
    }
}