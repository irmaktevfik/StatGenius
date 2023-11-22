using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ITopScorersRepository
{
    Task<IEnumerable<TopScorrers>> GetBySeasonId(int id);
    Task<IEnumerable<TopScorrers>> GetByStageId(int id);
}