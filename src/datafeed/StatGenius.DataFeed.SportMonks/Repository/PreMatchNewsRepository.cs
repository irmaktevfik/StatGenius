using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class PreMatchNewsRepository : SportMonksFootballClient, IPreMatchNewsRepository
{
    public async Task<IEnumerable<PreMatchNews>> GetAll()
    {
        var response = await base.GetListAsync<PreMatchNews>($"news/pre-match");
        if (response.Any())
            return response;
        return Enumerable.Empty<PreMatchNews>();
    }

    public async Task<IEnumerable<PreMatchNews>> GetBySeasonId(int id)
    {
        var response = await base.GetListAsync<PreMatchNews>($"news/pre-match/seasons/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<PreMatchNews>();
    }

    public async Task<IEnumerable<PreMatchNews>> GetUpcoming()
    {
        var response = await base.GetListAsync<PreMatchNews>($"news/pre-match/upcoming");
        if (response.Any())
            return response;
        return Enumerable.Empty<PreMatchNews>();
    }
}