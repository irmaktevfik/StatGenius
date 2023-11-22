using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IStagesRepository
{
    Task<IEnumerable<Stages>> GetAll();
    Task<Stages> GetId(int id);
    Task<IEnumerable<Stages>> GetBySeasonId(int id);
    Task<IEnumerable<Stages>> GetByNameSearch(string searchQuery);
}