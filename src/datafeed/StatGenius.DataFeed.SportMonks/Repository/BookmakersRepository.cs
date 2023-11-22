using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class BookmakersRepository: SportMonksOddsClient, IBookmakersRepository
{
    public async Task<IEnumerable<Bookmakers>> GetAll()
    {
        var response = await base.GetListAsync<Bookmakers>(nameof(Bookmakers).ToLower());
        return response.Any() ? response : Enumerable.Empty<Bookmakers>();
    }

    public async Task<Bookmakers> GetId(int id)
    {
        var response = await base.GetSingleAsync<Bookmakers>($"{nameof(Bookmakers).ToLower()}/{id}");
        return response;
    }

    public async Task<IEnumerable<Bookmakers>> GetByFixtureId(int id)
    {
        var response = await base.GetListAsync<Bookmakers>($"{nameof(Bookmakers).ToLower()}/{nameof(Fixtures).ToLower()}/{id}");
        return response.Any() ? response : Enumerable.Empty<Bookmakers>();
    }

    public async Task<IEnumerable<Bookmakers>> GetByNameSearch(string searchQuery)
    {
        var response = await base.GetListAsync<Bookmakers>($"{nameof(Bookmakers).ToLower()}/search/{searchQuery}");
        return response.Any() ? response : Enumerable.Empty<Bookmakers>();
    }
}