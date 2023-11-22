using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class TvStationsRepository : SportMonksFootballClient, ITvStationsRepository
{
    public async Task<IEnumerable<TvStations>> GetAll()
    {
        var response = await base.GetListAsync<TvStations>($"tv-stations");
        if (response.Any())
            return response;
        return Enumerable.Empty<TvStations>();
    }

    public async Task<TvStations> GetId(int id)
    {
        var response = await base.GetSingleAsync<TvStations>($"tv-stations/{id}");
        if (response is not null)
            return response;
        return null;  
    }

    public async Task<IEnumerable<TvStations>> GetByFixtureId(int id)
    {
        var response = await base.GetListAsync<TvStations>($"tv-stations/fixtures/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<TvStations>();
    }
}