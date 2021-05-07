
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RepositoryPatternDemoDone.Interfaces;
using RepositoryPatternDemoDone.Models;

namespace RepositoryPatternDemoDone.Repositories
{
    public class NeighbourhoodRepository : INeighbourhoodsRepository
    {
        private readonly RepositoryPatternDemoDoneDBContext _context;
        
        public NeighbourhoodRepository(RepositoryPatternDemoDoneDBContext context)
        {
            _context = context;
        }
        
        public async Task<Neighbourhood> CreateNeighbourhoodAsync(Neighbourhood neighbourhood)
        {
            _context.Add(neighbourhood);
            await _context.SaveChangesAsync();
            return neighbourhood;
        }

        public async Task<List<Neighbourhood>> GetAllNeighbourhoodsAsync()
        {
            return await _context.Neighbourhoods.ToListAsync();
        }

        public async Task<Neighbourhood> GetNeighbourhoodByIdAsync(string id)
        {
            return await _context.Neighbourhoods.FirstOrDefaultAsync(m => m.Neighbourhood1 == id);
        }
    }
}