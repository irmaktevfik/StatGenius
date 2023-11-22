using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class TeamsRepository : SportMonksFootballClient, ITeamsRepository
{
    public async Task<IEnumerable<Teams>> GetAll()
    {
        var response = await base.GetListAsync<Teams>($"teams");
        if (response.Any())
            return response;
        return Enumerable.Empty<Teams>();  
    }

    public async Task<Teams> GetId(int id)
    {
        var response = await base.GetSingleAsync<Teams>($"teams/{id}");
        if (response is not null)
            return response;
        return null;  
    }

    public async Task<IEnumerable<Teams>> GetByCountryId(int id)
    {
        var response = await base.GetListAsync<Teams>($"teams/countries/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Teams>();  
    }

    public async Task<IEnumerable<Teams>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<Teams>($"teams/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Teams>();  
    }

    public async Task<IEnumerable<Teams>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Teams>($"teams/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Teams>();  
    }
}