using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RiserAPI.Data;
using RiserAPI.Data.Interfaces;
using RiserAPI.Data.Repository;
using RiserAPI.Models;
using RiserAPI.Models.Jump;

namespace RiserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        private ApplicationDbContext _context;
        //private IContextService _context;
        public AircraftController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        [Route("all")]
        [Route("")]
        public IActionResult Get()
        {
            return Ok(_context.Aircraft.ToList());
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int? id)
        {
            if (id != null)
            {
                return Ok(_context.Aircraft.Find(id));
            }
            return BadRequest();
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _context.Aircraft.Add(aircraft);
                _context.SaveChanges();
                return Ok(aircraft);
            }

            return BadRequest();
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Aircraft aircraft)
        {
            return NotFound();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NotFound();
        }
    }
}