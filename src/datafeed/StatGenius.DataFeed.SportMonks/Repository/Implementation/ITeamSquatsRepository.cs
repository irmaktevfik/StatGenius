using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ITeamSquatsRepository
{
    Task<IEnumerable<TeamSquads>> GetByTeamId(int id);
    Task<IEnumerable<TeamSquads>> GetBySeasonAndTeamId(int seasonId,int teamId);
}