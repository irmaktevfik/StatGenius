using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class TopScorersRepository : SportMonksFootballClient, ITopScorersRepository
{
    public async Task<IEnumerable<TopScorrers>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<TopScorrers>($"topscorers/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<TopScorrers>();  
    }

    public async Task<IEnumerable<TopScorrers>> GetByStageId(int id)
    {
        var response = await base.GetListAsync<TopScorrers>($"topscorers/stages/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<TopScorrers>();  
    }
}