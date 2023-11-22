using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class MarketsRepository : SportMonksOddsClient, IMarketsRepository
{
    public async Task<IEnumerable<Markets>> GetAll()
    {
        var response = await base.GetListAsync<Markets>($"markets");
        if (response.Any())
            return response;
        return Enumerable.Empty<Markets>();
    }

    public async Task<Markets> GetId(int id)
    {
        var response = await base.GetSingleAsync<Markets>($"markets/{id}");
        if (response is not null)
            return response;
        return null;
    }

    public async Task<IEnumerable<Markets>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Markets>($"markets/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Markets>();
    }
}