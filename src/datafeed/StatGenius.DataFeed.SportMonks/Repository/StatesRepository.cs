using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class StatesRepository : SportMonksFootballClient, IStatesRepository
{
    public async Task<IEnumerable<States>> GetAll()
    {
        var response = await base.GetListAsync<States>($"{nameof(States).ToLower()}");
        if (response.Any())
            return response;
        return Enumerable.Empty<States>();
    }

    public async Task<States> GetById(int id)
    {
        var response = await base.GetSingleAsync<States>($"{nameof(States).ToLower()}/seasons/{id}");
        if (response is not null)
            return response;
        return null;
    }
}