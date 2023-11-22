using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IPlayersRepository
{
    Task<IEnumerable<Players>> GetAll();
    Task<Players> GetId(int id);
    Task<IEnumerable<Players>> GetByCountryId(int id);
    Task<IEnumerable<Players>> GetByNameSearch(string searchQuery);
    Task<IEnumerable<Players>> GetLastUpdated();
}