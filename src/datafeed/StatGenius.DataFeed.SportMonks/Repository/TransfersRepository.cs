using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class TransfersRepository : SportMonksFootballClient, ITransfersRepository
{
    public async Task<IEnumerable<Transfers>> GetAll()
    {
        var response = await base.GetListAsync<Transfers>($"transfers");
        if (response.Any())
            return response;
        return Enumerable.Empty<Transfers>();  
    }

    public async Task<Transfers> GetId(int id)
    {
        var response = await base.GetSingleAsync<Transfers>($"transfers/{id}");
        if (response is not null)
            return response;
        return null;  
    }

    public async Task<IEnumerable<Transfers>> GetLatest(int id)
    {
        var response = await base.GetListAsync<Transfers>($"transfers/latest");
        if (response.Any())
            return response;
        return Enumerable.Empty<Transfers>();  
    }

    public async Task<IEnumerable<Transfers>> GetByDateRange(DateTimeOffset start_date, DateTimeOffset end_date)
    {
        var response = await base.GetListAsync<Transfers>($"transfers/between/{start_date.ToString()}/{end_date.ToString()}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Transfers>();  
    }

    public async Task<IEnumerable<Transfers>> GetByTeamId(int id)
    {
        var response = await base.GetListAsync<Transfers>($"transfers/teams/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Transfers>();  
    }

    public async Task<IEnumerable<Transfers>> GetByPlayerId(int id)
    {
        var response = await base.GetListAsync<Transfers>($"transfers/players/{id}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Transfers>();  
    }
}