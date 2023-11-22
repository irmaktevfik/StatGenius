using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class PreMatchOddsRepository : SportMonksFootballClient, IPreMatchOddsRepository
{
    public async Task<IEnumerable<PreMatchOdds>> GetAll()
    {
        var response = await base.GetListAsync<PreMatchOdds>($"odds/pre-match");
        if (response.Any())
            return response;
        return Enumerable.Empty<PreMatchOdds>();
    }

    public async Task<IEnumerable<PreMatchOdds>> GetByFixtureId(int id)
    {
        var response = await base.GetListAsync<PreMatchOdds>($"odds/pre-match/fixtures/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<PreMatchOdds>();
    }

    public async Task<IEnumerable<PreMatchOdds>> GetByFixtureIdAndBookmakerId(int fixture_id, int bookmaker_id)
    {
        var response = await base.GetListAsync<PreMatchOdds>($"odds/pre-match/fixtures/{fixture_id}/bookmakers/{bookmaker_id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<PreMatchOdds>();
    }

    public async Task<IEnumerable<PreMatchOdds>> GetByFixtureIdAndMarketId(int fixture_id, int market_id)
    {
        var response = await base.GetListAsync<PreMatchOdds>($"odds/pre-match/fixtures/{fixture_id}/bookmakers/{market_id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<PreMatchOdds>();
    }

    public async Task<IEnumerable<PreMatchOdds>> GetLastUpdated()
    {
        var response = await base.GetListAsync<PreMatchOdds>($"odds/pre-match/latest");
        if (response.Any())
            return response;
        return Enumerable.Empty<PreMatchOdds>();
    }
}