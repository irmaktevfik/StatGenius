using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IRoundsRepository
{
    Task<IEnumerable<Rounds>> GetAll();
    Task<Rounds> GetId(int id);
    Task<IEnumerable<Rounds>> GetBySeasonId(int id);
    Task<IEnumerable<Rounds>> GetByNameSearch(string searchQuery);
}