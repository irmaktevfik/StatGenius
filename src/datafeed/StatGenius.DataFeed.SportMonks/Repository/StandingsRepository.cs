using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class StandingsRepository : SportMonksFootballClient, IStandingsRepository
{
    public async Task<IEnumerable<Standings>> GetAll()
    {
        var response = await base.GetListAsync<Standings>($"{nameof(Standings).ToLower()}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Standings>();
    }

    public async Task<IEnumerable<Standings>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<Standings>($"{nameof(Standings).ToLower()}/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Standings>();
    }

    public async Task<IEnumerable<Standings>> GetByRoundId(int id)
    {
        var response = await base.GetListAsync<Standings>($"{nameof(Standings).ToLower()}/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Standings>();
    }

    public async Task<IEnumerable<Standings>> GetStandingCorrectionBySeasonId(int id)
    {
        var response = await base.GetListAsync<Standings>($"{nameof(Standings).ToLower()}/corrections/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Standings>();
    }

    public async Task<IEnumerable<Standings>> GetLiveStandingsBySeasonId(int id)
    {
        var response = await base.GetListAsync<Standings>($"{nameof(Standings).ToLower()}/live/leagues/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Standings>();
    }
}