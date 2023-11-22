using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class LiveScoresRepository : SportMonksFootballClient, ILiveScoresRepository
{
    public async Task<IEnumerable<LiveScores>> GetInplay()
    {
        var response = await base.GetListAsync<LiveScores>($"livescores/inplay");
        if (response.Any())
            return response;
        return Enumerable.Empty<LiveScores>();
    }

    public async Task<IEnumerable<LiveScores>> GetAll()
    {
        var response = await base.GetListAsync<LiveScores>($"livescores");
        if (response.Any())
            return response;
        return Enumerable.Empty<LiveScores>();
    }

    public async Task<IEnumerable<LiveScores>> GetLatestUpdated()
    {
        var response = await base.GetListAsync<LiveScores>($"livescores/latest");
        if (response.Any())
            return response;
        return Enumerable.Empty<LiveScores>();
    }
}