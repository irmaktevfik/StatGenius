using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class SeasonsRepository : SportMonksFootballClient, ISeasonsRepository
{
    public async Task<IEnumerable<Seasons>> GetAll()
    {
        var response = await base.GetListAsync<Seasons>($"{nameof(Seasons).ToLower()}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Seasons>();
    }

    public async Task<Seasons> GetById(int id)
    {
        var response = await base.GetSingleAsync<Seasons>($"{nameof(Seasons).ToLower()}/{id}");
        if (response is not null)
            return response;
        return null;
    }

    public async Task<IEnumerable<Seasons>> GetByTeamId(int id)
    {
        var response = await base.GetListAsync<Seasons>($"{nameof(Seasons).ToLower()}/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Seasons>();
    }

    public async Task<IEnumerable<Seasons>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Seasons>($"{nameof(Seasons).ToLower()}/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Seasons>();
    }
}