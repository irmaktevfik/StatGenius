using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IRepository
{
    Task<IEnumerable<Stages>> GetAll();
    Task<IEnumerable<Stages>> GetId(int id);
    Task<IEnumerable<Stages>> GetBySeasonId(int id);
    Task<IEnumerable<Stages>> GetByNameSearch(string searchQuery);
}