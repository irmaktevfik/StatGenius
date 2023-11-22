using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IPreMatchOddsRepository
{
    Task<IEnumerable<PreMatchOdds>> GetAll();
    Task<IEnumerable<PreMatchOdds>> GetByFixtureId(int id);
    Task<IEnumerable<PreMatchOdds>> GetByFixtureIdAndBookmakerId(int fixture_id, int bookmaker_id);
    Task<IEnumerable<PreMatchOdds>> GetByFixtureIdAndMarketId(int fixture_id, int market_id);
    Task<IEnumerable<PreMatchOdds>> GetLastUpdated();
}