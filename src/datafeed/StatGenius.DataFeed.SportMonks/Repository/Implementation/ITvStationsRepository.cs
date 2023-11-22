using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ITvStationsRepository
{
    Task<IEnumerable<TvStations>> GetAll();
    Task<TvStations> GetId(int id);
    Task<IEnumerable<TvStations>> GetByFixtureId(int id);
}