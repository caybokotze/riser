using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RiserAPI.Data;

namespace RiserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController : Controller
    {
        private ApplicationDbContext _context;
        public SaleController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Sales.ToList());
        }
    }
}