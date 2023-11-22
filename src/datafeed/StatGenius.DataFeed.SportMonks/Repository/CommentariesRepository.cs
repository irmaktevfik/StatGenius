using StatGenius.DataFeed.Models.Client;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository;

public class CommentariesRepository: SportMonksFootballClient, ICommentariesRepository
{
    public async Task<IEnumerable<Commentaries>> GetAll()
    {
        var response = await base.GetListAsync<Commentaries>($"{nameof(Commentaries).ToLower()}");
        if (response.Any())
            return response;
        return Enumerable.Empty<Commentaries>();
    }

    public async Task<IEnumerable<Commentaries>> GetByFixtureId(int id)
    {
        var response = await base.GetListAsync<Commentaries>($"{nameof(Commentaries).ToLower()}/{nameof(Fixtures).ToLower()}/{id}");
        if (response is not null)
            return response;
        return Enumerable.Empty<Commentaries>();
    }
}