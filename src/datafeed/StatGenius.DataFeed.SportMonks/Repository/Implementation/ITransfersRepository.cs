using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ITransfersRepository
{
    Task<IEnumerable<Transfers>> GetAll();
    Task<Transfers> GetId(int id);
    Task<IEnumerable<Transfers>> GetLatest(int id);
    Task<IEnumerable<Transfers>> GetByDateRange(DateTimeOffset start_date, DateTimeOffset end_date);
    Task<IEnumerable<Transfers>> GetByTeamId(int id);
    Task<IEnumerable<Transfers>> GetByPlayerId(int id);
}