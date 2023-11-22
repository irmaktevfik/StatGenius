using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IStandingsRepository
{
    Task<IEnumerable<Standings>> GetAll();
    Task<IEnumerable<Standings>> GetBySeasonId(int id);
    Task<IEnumerable<Standings>> GetByRoundId(int id);
    Task<IEnumerable<Standings>> GetStandingCorrectionBySeasonId(int id);
    Task<IEnumerable<Standings>> GetLiveStandingsBySeasonId(int id);
}