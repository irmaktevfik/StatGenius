using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ILeaguesRepository
{
    Task<IEnumerable<Leagues>> GetAll();
    Task<Leagues> GetById(int id);
    Task<IEnumerable<Leagues>> GetAllLive();
    Task<IEnumerable<Leagues>> GetByFixtureDate(DateTimeOffset date);
    Task<IEnumerable<Leagues>> GetByCountryId(int id);
    Task<IEnumerable<Leagues>> GetByTeamId(int id);
    Task<IEnumerable<Leagues>> GetByNameSearch(string searchQuery);
    Task<IEnumerable<Leagues>> GetCurrentByTeamId(int id);
}