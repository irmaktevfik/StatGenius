using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IMarketsRepository
{
    Task<IEnumerable<Markets>> GetAll();
    Task<Markets> GetId(int id);
    Task<IEnumerable<Markets>> GetByNameSearch(string searchQuery);
}