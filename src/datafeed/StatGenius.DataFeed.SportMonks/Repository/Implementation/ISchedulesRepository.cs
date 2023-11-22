using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ISchedulesRepository
{
    Task<IEnumerable<Schedules>> GetBySeasonId(int id);
    Task<IEnumerable<Schedules>> GetByTeamId(int id);
    Task<IEnumerable<Schedules>> GetBySeasonAndTeamId(int seasonId,int teamId);
}