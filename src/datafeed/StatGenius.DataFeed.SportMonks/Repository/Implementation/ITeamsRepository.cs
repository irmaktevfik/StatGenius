using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ITeamsRepository
{
    Task<IEnumerable<Teams>> GetAll();
    Task<Teams> GetId(int id);
    Task<IEnumerable<Teams>> GetByCountryId(int id);
    Task<IEnumerable<Teams>> GetBySeasonId(int id);
    Task<IEnumerable<Teams>> GetByNameSearch(string searchQuery);
}