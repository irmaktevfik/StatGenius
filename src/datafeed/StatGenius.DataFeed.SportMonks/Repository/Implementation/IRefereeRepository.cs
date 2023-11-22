using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IRefereeRepository
{
    Task<IEnumerable<Referees>> GetAll();
    Task<Referees> GetId(int id);
    Task<IEnumerable<Referees>> GetByCountryId(int id);
    Task<IEnumerable<Referees>> GetBySeasonId(int id);    
    Task<IEnumerable<Referees>> GetByNameSearch(string searchQuery);
}