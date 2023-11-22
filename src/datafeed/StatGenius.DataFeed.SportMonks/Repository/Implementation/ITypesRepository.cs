using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ITypesRepository
{
    Task<IEnumerable<Types>> GetAll();
    Task<Types> GetById(int id);
}