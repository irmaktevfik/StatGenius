using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class TeamSquatsRepository : SportMonksFootballClient, ITeamSquatsRepository
{
    public async Task<IEnumerable<TeamSquads>> GetByTeamId(int id)
    {
        var response = await base.GetListAsync<TeamSquads>($"squads/teams/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<TeamSquads>();    
    }

    public async Task<IEnumerable<TeamSquads>> GetBySeasonAndTeamId(int seasonId, int teamId)
    {
        var response = await base.GetListAsync<TeamSquads>($"squads/seasons/{seasonId}/teams/{teamId}/");
        if (response.Any())
            return response;
        return Enumerable.Empty<TeamSquads>();    
    }
}