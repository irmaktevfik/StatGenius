
using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class TypesRepository : SportMonksCoreClient, ITypesRepository
{
    public async Task<IEnumerable<Types>> GetAll()
    {
        var response = await base.GetListAsync<Types>(nameof(Types).ToLower());
        if (response.Any())
            return response;
        return Enumerable.Empty<Types>();
    }
    
    public async Task<Types?> GetById(int id)
    {
        var response = await base.GetSingleAsync<Types>($"{nameof(Types).ToLower()}/{id}");
        if (response is not null)
            return response;
        return null;
    }
}