using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class FixturesRepository: SportMonksFootballClient, IFixturesRepository
{
    public async Task<IEnumerable<Fixtures>> GetAll(FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>(nameof(Fixtures).ToLower());
        if (response.Any())
            return response;
        return Enumerable.Empty<Fixtures>();
    }

    public async Task<IEnumerable<Fixtures>> GetById(int id, FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/{id}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetByIds(int[] ids, FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/multi/{string.Join('&',ids)}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetByDate(DateTimeOffset date, FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/date/{date}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetByDateRange(DateTimeOffset start_date, DateTimeOffset end_date,
        FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/between/{start_date}/{end_date}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetByDateRange(DateTimeOffset start_date, DateTimeOffset end_date, int teamId,
        FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/between/{start_date}/{end_date}/{teamId}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetByHeadToHead(int team_id_1, int team_id_2, FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/head-to-head/{team_id_1}/{team_id_2}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetByNameSearch(string searchQuery, FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/search/{searchQuery}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetUpcomingByMarketId(int marketId, FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/upcoming/markets/{marketId}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetUpcomingByTvStationId(int tvStationId, FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/upcoming/tv-stations/{tvStationId}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetPastByTvStationId(int tvStationId, FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/past/tv-stations/{tvStationId}");
        if (response.Any())
            return response;
        return null;
    }

    public async Task<IEnumerable<Fixtures>> GetLatestUpdated(FixtureRequestWithIncludedFilters? includedFilters = null)
    {
        var response = await base.GetListAsync<Fixtures>($"{nameof(Fixtures).ToLower()}/latest");
        if (response.Any())
            return response;
        return null;
    }
}