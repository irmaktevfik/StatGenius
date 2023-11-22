using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IVenuesRepository
{
    Task<IEnumerable<Venues>> GetAll();
    Task<Venues> GetId(int id);
    Task<IEnumerable<Venues>> GetBySeasonId(int id);    
    Task<IEnumerable<Venues>> GetByNameSearch(string searchQuery);
}