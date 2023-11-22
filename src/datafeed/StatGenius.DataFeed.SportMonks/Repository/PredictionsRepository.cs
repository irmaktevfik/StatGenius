using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class PredictionsRepository : SportMonksFootballClient, IPredictionsRepository
{
    public async Task<IEnumerable<Probabilities>> GetAll()
    {
        var response = await base.GetListAsync<Probabilities>($"predictions/probabilities");
        if (response.Any())
            return response;
        return Enumerable.Empty<Probabilities>();
    }

    public async Task<IEnumerable<Probabilities>> GetByLeagueId(int id)
    {
        var response = await base.GetListAsync<Probabilities>($"predictions/probabilities/leagues/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Probabilities>();
    }

    public async Task<IEnumerable<Probabilities>> GetByFixtureId(int id)
    {
        var response = await base.GetListAsync<Probabilities>($"predictions/probabilities/fixtures/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Probabilities>();
    }

    public async Task<IEnumerable<Probabilities>> GetValueBets()
    {
        var response = await base.GetListAsync<Probabilities>($"predictions/value-bets");
        if (response.Any())
            return response;
        return Enumerable.Empty<Probabilities>();
    }

    public async Task<IEnumerable<Probabilities>> GetValueBetsByFixtureId(int id)
    {
        var response = await base.GetListAsync<Probabilities>($"predictions/value-bets/fixtures/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Probabilities>();
    }
}