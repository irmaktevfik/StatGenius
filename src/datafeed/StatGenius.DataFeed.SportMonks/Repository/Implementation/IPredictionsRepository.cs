using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IPredictionsRepository
{
    Task<IEnumerable<Probabilities>> GetAll();
    Task<IEnumerable<Probabilities>> GetByLeagueId(int id);
    Task<IEnumerable<Probabilities>> GetByFixtureId(int id);
    Task<IEnumerable<Probabilities>> GetValueBets();
    Task<IEnumerable<Probabilities>> GetValueBetsByFixtureId(int id);
}