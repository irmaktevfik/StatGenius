using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IStatesRepository
{
    Task<IEnumerable<States>> GetAll();
    Task<States> GetById(int id);
}