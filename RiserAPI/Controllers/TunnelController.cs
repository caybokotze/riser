using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RiserAPI.Data;

namespace RiserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TunnelController : Controller
    {
        private ApplicationDbContext _context;
        public TunnelController()
        {
            _context = new ApplicationDbContext();
        }
        
        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.TunnelSessions.ToList());
        }
    }
}