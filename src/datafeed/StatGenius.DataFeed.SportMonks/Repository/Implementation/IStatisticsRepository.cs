using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IStatisticsRepository
{
    Task<IEnumerable<SeasonStatistics>> GetSeasonStatisticsByPlayer(int id);
    Task<IEnumerable<SeasonStatistics>> GetSeasonStatisticsByTeam(int id);
    Task<IEnumerable<SeasonStatistics>> GetSeasonStatisticsByCoach(int id);
    Task<IEnumerable<SeasonStatistics>> GetSeasonStatisticsByReferee(int id);
    Task<IEnumerable<StageStatistics>> GetStageStatisticsById(int id);
    Task<IEnumerable<RoundStatistics>> GetRoundStatisticsById(int id);
}