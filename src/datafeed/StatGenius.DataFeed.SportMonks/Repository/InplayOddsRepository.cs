using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class InplayOddsRepository: SportMonksOddsClient, IInplayOddsRepository
{
    public async Task<IEnumerable<InplayOdds>> GetAll()
    {
        var response = await base.GetListAsync<InplayOdds>($"inplay");
        if (response.Any())
            return response;
        return Enumerable.Empty<InplayOdds>();
    }

    public async Task<IEnumerable<InplayOdds>> GetByFixtureId(int id)
    {
        var response = await base.GetListAsync<InplayOdds>($"inplay/fixtures/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<InplayOdds>();
    }

    public async Task<IEnumerable<InplayOdds>> GetByFixtureIdAndBookmakerId(int fixture_id, int bookmaker_id)
    {
        var response = await base.GetListAsync<InplayOdds>($"inplay/fixtures/{fixture_id}/bookmakers/{bookmaker_id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<InplayOdds>();
    }

    public async Task<IEnumerable<InplayOdds>> GetByFixtureIdAndMarketId(int fixture_id, int market_id)
    {
        var response = await base.GetListAsync<InplayOdds>($"inplay/fixtures/{fixture_id}/markets/{market_id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<InplayOdds>();
    }

    public async Task<IEnumerable<InplayOdds>> GetLastUpdated()
    {
        var response = await base.GetListAsync<InplayOdds>($"inplay/latest");
        if (response.Any())
            return response;
        return Enumerable.Empty<InplayOdds>();
    }
}