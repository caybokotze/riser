using RiserAPI.Data.Interfaces.Repository;
using RiserAPI.Models;
using RiserAPI.Models.Gear;

namespace RiserAPI.Data.Repository.Models
{
    public class GearItemRepository : Repository<GearItem>, IGearItemRepository
    {
        public GearItemRepository(ApplicationDbContext context) : base(context)
        {
        }

        private ApplicationDbContext ApplicationDbContext => Context;

    }
}