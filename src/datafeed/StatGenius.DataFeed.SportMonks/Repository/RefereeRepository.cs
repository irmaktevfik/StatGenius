using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class RefereeRepository : SportMonksFootballClient, IRefereeRepository
{
    public async Task<IEnumerable<Referees>> GetAll()
    {
        var response = await base.GetListAsync<Referees>($"referees");
        if (response.Any())
            return response;
        return Enumerable.Empty<Referees>();
    }

    public async Task<Referees> GetId(int id)
    {
        var response = await base.GetSingleAsync<Referees>($"referees/{id}");
        if (response is not null)
            return response;
        return null;
    }

    public async Task<IEnumerable<Referees>> GetByCountryId(int id)
    {
        var response = await base.GetListAsync<Referees>($"referees/countries/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Referees>();
    }

    public async Task<IEnumerable<Referees>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<Referees>($"referees/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Referees>();
    }

    public async Task<IEnumerable<Referees>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Referees>($"referees/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Referees>();
    }
}