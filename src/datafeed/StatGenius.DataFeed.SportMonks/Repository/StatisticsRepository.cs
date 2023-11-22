using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class StatisticsRepository : SportMonksFootballClient, IStatisticsRepository
{
    public async Task<IEnumerable<SeasonStatistics>> GetSeasonStatisticsByPlayer(int id)
    {
        var response = await base.GetListAsync<SeasonStatistics>($"statistics/seasons/{id}/");
        if (response.Any())
            return response;
        return Enumerable.Empty<SeasonStatistics>();    
    }

    public async Task<IEnumerable<SeasonStatistics>> GetSeasonStatisticsByTeam(int id)
    {
        var response = await base.GetListAsync<SeasonStatistics>($"statistics/seasons/{id}/");
        if (response.Any())
            return response;
        return Enumerable.Empty<SeasonStatistics>();    
    }

    public async Task<IEnumerable<SeasonStatistics>> GetSeasonStatisticsByCoach(int id)
    {
        var response = await base.GetListAsync<SeasonStatistics>($"statistics/seasons/{id}/");
        if (response.Any())
            return response;
        return Enumerable.Empty<SeasonStatistics>();    
    }

    public async Task<IEnumerable<SeasonStatistics>> GetSeasonStatisticsByReferee(int id)
    {
        var response = await base.GetListAsync<SeasonStatistics>($"statistics/seasons/{id}/");
        if (response.Any())
            return response;
        return Enumerable.Empty<SeasonStatistics>();    
    }

    public async Task<IEnumerable<StageStatistics>> GetStageStatisticsById(int id)
    {
        var response = await base.GetListAsync<StageStatistics>($"statistics/stages/{id}/");
        if (response.Any())
            return response;
        return Enumerable.Empty<StageStatistics>();    
    }

    public async Task<IEnumerable<RoundStatistics>> GetRoundStatisticsById(int id)
    {
        var response = await base.GetListAsync<RoundStatistics>($"statistics/rounds/{id}/");
        if (response.Any())
            return response;
        return Enumerable.Empty<RoundStatistics>();    
    }
}