using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class RoundsRepository : SportMonksFootballClient, IRoundsRepository
{
    public async Task<IEnumerable<Rounds>> GetAll()
    {
        var response = await base.GetListAsync<Rounds>($"rounds");
        if (response.Any())
            return response;
        return Enumerable.Empty<Rounds>();
    }

    public async Task<Rounds> GetId(int id)
    {
        var response = await base.GetSingleAsync<Rounds>($"rounds/{id}");
        if (response is not null)
            return response;
        return null;
    }

    public async Task<IEnumerable<Rounds>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<Rounds>($"rounds/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Rounds>();
    }

    public async Task<IEnumerable<Rounds>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Rounds>($"rounds/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Rounds>();
    }
}