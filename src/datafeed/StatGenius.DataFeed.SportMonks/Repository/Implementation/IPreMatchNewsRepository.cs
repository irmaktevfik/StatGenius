using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface IPreMatchNewsRepository
{
    Task<IEnumerable<PreMatchNews>> GetAll();
    Task<IEnumerable<PreMatchNews>> GetBySeasonId(int id);    
    Task<IEnumerable<PreMatchNews>> GetUpcoming();
}