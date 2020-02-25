using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using RiserAPI.Data.Interfaces;
using RiserAPI.Data.Interfaces.Repository;
using RiserAPI.Models;
using RiserAPI.Models.Jump;

namespace RiserAPI.Data.Repository.Models
{
    public class AircraftRepository : Repository<Aircraft>, IAircraftRepository
    {
        public AircraftRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext ApplicationDbContext => Context;

        public IEnumerable<Aircraft> GetAllAircraft()
        {
            return Context.Aircrafts.ToList();
        }
        
        public IEnumerable<Aircraft> GetAllAircraft(int aircraftId)
        {
            return Context.Aircrafts.Where(w => w.Id == aircraftId).ToList();
        }
    }
}