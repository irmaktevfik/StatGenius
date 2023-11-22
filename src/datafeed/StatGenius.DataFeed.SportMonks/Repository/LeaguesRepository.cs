using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class LeaguesRepository :SportMonksFootballClient, ILeaguesRepository
{
    public async Task<IEnumerable<Leagues>> GetAll()
    {
        var response = await base.GetListAsync<Leagues>($"leagues");
        if (response.Any())
            return response;
        return Enumerable.Empty<Leagues>();
    }

    public async Task<Leagues> GetById(int id)
    {
        var response = await base.GetSingleAsync<Leagues>($"leagues/{id}");
        if (response is not null)
            return response;
        return null;
    }

    public async Task<IEnumerable<Leagues>> GetAllLive()
    {
        var response = await base.GetListAsync<Leagues>($"leagues/live");
        if (response.Any())
            return response;
        return Enumerable.Empty<Leagues>();
    }

    public async Task<IEnumerable<Leagues>> GetByFixtureDate(DateTimeOffset date)
    {
        var response = await base.GetListAsync<Leagues>($"leagues/date/{date}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Leagues>();
    }

    public async Task<IEnumerable<Leagues>> GetByCountryId(int id)
    {
        var response = await base.GetListAsync<Leagues>($"leagues/countries/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Leagues>();
    }

    public async Task<IEnumerable<Leagues>> GetByTeamId(int id)
    {
        var response = await base.GetListAsync<Leagues>($"leagues/teams/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Leagues>();
    }

    public async Task<IEnumerable<Leagues>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Leagues>($"leagues/search/{searchQuery}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Leagues>();
    }

    public async Task<IEnumerable<Leagues>> GetCurrentByTeamId(int id)
    {
        var response = await base.GetListAsync<Leagues>($"leagues/leagues/teams/{id}/current");
        if (response.Any())
            return response;
        return Enumerable.Empty<Leagues>();
    }
}