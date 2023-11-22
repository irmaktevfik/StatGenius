using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ISeasonsRepository
{
    Task<IEnumerable<Seasons>> GetAll();
    Task<Seasons> GetById(int id);
    Task<IEnumerable<Seasons>> GetByTeamId(int id);
    Task<IEnumerable<Seasons>> GetByNameSearch(string searchQuery);
}