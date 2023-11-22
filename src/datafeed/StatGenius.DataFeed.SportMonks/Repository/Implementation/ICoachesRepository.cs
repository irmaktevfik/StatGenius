using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ICoachesRepository
{
    Task<IEnumerable<Coaches>> GetAll();
    Task<Coaches?> GetById(int id);
    Task<IEnumerable<Coaches>> GetByCountryId(int id);
    Task<IEnumerable<Coaches>> GetByNameSearch(string searchQuery);
    Task<IEnumerable<Coaches>> GetLastUpdated();
}