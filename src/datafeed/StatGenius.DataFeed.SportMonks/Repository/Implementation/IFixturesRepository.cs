using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IFixturesRepository
{
    Task<IEnumerable<Fixtures>> GetAll(FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetById(int id,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetByIds(int[] ids,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetByDate(DateTimeOffset date,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetByDateRange(DateTimeOffset start_date, DateTimeOffset end_date,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetByDateRange(DateTimeOffset start_date, DateTimeOffset end_date, int teamId,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetByHeadToHead(int team_id_1, int team_id_2,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetByNameSearch(string searchQuery,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetUpcomingByMarketId(int marketId,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetUpcomingByTvStationId(int tvStationId,FixtureRequestWithIncludedFilters? includedFilters = null);
    Task<IEnumerable<Fixtures>> GetPastByTvStationId(int tvStationId,FixtureRequestWithIncludedFilters? includedFilters = null);    
    Task<IEnumerable<Fixtures>> GetLatestUpdated(FixtureRequestWithIncludedFilters? includedFilters = null);
}

public record FixtureRequestWithIncludedFilters(bool includeMatch, bool includePlayerStatistics, bool includeLineups, bool includeEvents);