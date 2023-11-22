using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class CoachesRepository :SportMonksFootballClient,  ICoachesRepository
{
    public async Task<IEnumerable<Coaches>> GetAll()
    {
        var response = await base.GetListAsync<Coaches>(nameof(Coaches).ToLower());
        if (response.Any())
            return response;
        return Enumerable.Empty<Coaches>();
    }
    
    public async Task<Coaches?> GetById(int id)
    {
        var response = await base.GetSingleAsync<Coaches>($"{nameof(Coaches)}/{id}");
        if (response is not null)
            return response;
        return null;
    }

    public async Task<IEnumerable<Coaches>> GetByCountryId(int id)
    {
        var response = await base.GetListAsync<Coaches>($"{nameof(Coaches).ToLower()}/countries/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Coaches>();
    }

    public async Task<IEnumerable<Coaches>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Coaches>($"{nameof(Coaches).ToLower()}/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Coaches>();
    }

    public async Task<IEnumerable<Coaches>> GetLastUpdated()
    {
        var response = await base.GetListAsync<Coaches>($"{nameof(Coaches).ToLower()}/latest");
        if (response.Any())
            return response;
        return Enumerable.Empty<Coaches>();    }
}