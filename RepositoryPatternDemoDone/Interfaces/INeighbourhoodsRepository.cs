using System.Collections.Generic;
using System.Threading.Tasks;
using RepositoryPatternDemoDone.Models;

namespace RepositoryPatternDemoDone.Interfaces
{
    public interface INeighbourhoodsRepository
    {
        // Get all Neighbourhood
        Task<List<Neighbourhood>> GetAllNeighbourhoodsAsync();
        
        // Get one Neighbourhood
        Task<Neighbourhood> GetNeighbourhoodByIdAsync(string id);
        
        // Create one Neighbourhood
        Task<Neighbourhood> CreateNeighbourhoodAsync(Neighbourhood neighbourhood);
    }
}