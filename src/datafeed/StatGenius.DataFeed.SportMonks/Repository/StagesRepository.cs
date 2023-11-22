using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class StagesRepository : SportMonksFootballClient, IStagesRepository
{
    public async Task<IEnumerable<Stages>> GetAll()
    {
        var response = await base.GetListAsync<Stages>($"{nameof(Stages).ToLower()}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Stages>();
    }

    public async Task<Stages> GetId(int id)
    {
        var response = await base.GetSingleAsync<Stages>($"{nameof(Stages).ToLower()}/{id}");
        if (response is not null)
            return response;
        return null;
    }

    public async Task<IEnumerable<Stages>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<Stages>($"{nameof(Stages).ToLower()}/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Stages>();
    }

    public async Task<IEnumerable<Stages>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Stages>($"{nameof(Stages).ToLower()}/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Stages>();
    }
}