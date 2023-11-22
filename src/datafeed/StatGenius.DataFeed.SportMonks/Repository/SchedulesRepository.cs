using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class SchedulesRepository : SportMonksFootballClient, ISchedulesRepository
{
    public async Task<IEnumerable<Schedules>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<Schedules>($"{nameof(Schedules).ToLower()}/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Schedules>();
    }

    public async Task<IEnumerable<Schedules>> GetByTeamId(int id)
    {
        var response = await base.GetListAsync<Schedules>($"{nameof(Schedules).ToLower()}/teams/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Schedules>();
    }

    public async Task<IEnumerable<Schedules>> GetBySeasonAndTeamId(int seasonId, int teamId)
    {
        var response = await base.GetListAsync<Schedules>($"{nameof(Schedules).ToLower()}/seasons/{seasonId}/teams/{teamId}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Schedules>();
    }
}