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
        public AircraftController(/*IContextService context*/)
        {
            _context = new ApplicationDbContext();
        }
        
        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_context.Aircraft);
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id != 0)
            {
                return Ok(_context.Aircraft.Get(id));
            }
            return BadRequest();
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                return Ok(_context.Aircraft.Add(aircraft));
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