using System.Net.Mime;
using RiserAPI.Data.Interfaces;
using RiserAPI.Data.Interfaces.Repository;
using RiserAPI.Data.Repository.Models;

namespace RiserAPI.Data.Repository
{
    public class ContextService : IContextService
    {
        private readonly ApplicationDbContext _context;
        
        public ContextService(ApplicationDbContext context)
        {
            _context = context;
            GearItems = new GearItemRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public IGearRepository GearItems { get; }
    }
}