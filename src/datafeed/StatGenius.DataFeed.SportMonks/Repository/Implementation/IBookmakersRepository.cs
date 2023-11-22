using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IBookmakersRepository
{
    Task<IEnumerable<Bookmakers>> GetAll();
    Task<Bookmakers> GetId(int id);
    Task<IEnumerable<Bookmakers>> GetByFixtureId(int id);
    Task<IEnumerable<Bookmakers>> GetByNameSearch(string searchQuery);
}