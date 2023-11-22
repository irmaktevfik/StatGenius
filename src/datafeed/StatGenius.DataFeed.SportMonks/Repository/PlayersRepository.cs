using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class PlayersRepository : SportMonksFootballClient, IPlayersRepository
{
    public async Task<IEnumerable<Players>> GetAll()
    {
        var response = await base.GetListAsync<Players>($"players");
        if (response.Any())
            return response;
        return Enumerable.Empty<Players>();
    }

    public async Task<Players> GetId(int id)
    {
        var response = await base.GetSingleAsync<Players>($"players/{id}");
        if (response is not null)
            return response;
        return null;
    }

    public async Task<IEnumerable<Players>> GetByCountryId(int id)
    {
        var response = await base.GetListAsync<Players>($"players/countries/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Players>();
    }

    public async Task<IEnumerable<Players>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Players>($"players/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Players>();
    }

    public async Task<IEnumerable<Players>> GetLastUpdated()
    {
        var response = await base.GetListAsync<Players>($"players/latest");
        if (response.Any())
            return response;
        return Enumerable.Empty<Players>();
    }
}