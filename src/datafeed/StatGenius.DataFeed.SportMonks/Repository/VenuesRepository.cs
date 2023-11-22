using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class VenuesRepository : SportMonksFootballClient, IVenuesRepository
{
    public async Task<IEnumerable<Venues>> GetAll()
    {
        var response = await base.GetListAsync<Venues>(nameof(Venues).ToLower());
        if (response.Any())
            return response;
        return Enumerable.Empty<Venues>();
    }

    public async Task<Venues> GetId(int id)
    {
        var response = await base.GetSingleAsync<Venues>($"{nameof(Venues).ToLower()}/{id}");
        if (response is not null)
            return response;
        return null;
    }


    public async Task<IEnumerable<Venues>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<Venues>($"{nameof(Venues).ToLower()}/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Venues>();
    }

    public async Task<IEnumerable<Venues>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Venues>($"{nameof(Venues).ToLower()}/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Venues>();
    }
}