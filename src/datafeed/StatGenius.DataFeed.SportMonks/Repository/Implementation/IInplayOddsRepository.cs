using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IInplayOddsRepository
{
    Task<IEnumerable<InplayOdds>> GetAll();
    Task<IEnumerable<InplayOdds>> GetByFixtureId(int id);
    Task<IEnumerable<InplayOdds>> GetByFixtureIdAndBookmakerId(int fixture_id, int bookmaker_id);
    Task<IEnumerable<InplayOdds>> GetByFixtureIdAndMarketId(int fixture_id, int market_id);
    Task<IEnumerable<InplayOdds>> GetLastUpdated();
}