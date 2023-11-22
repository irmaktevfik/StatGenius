using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ICommentariesRepository
{
    Task<IEnumerable<Commentaries>> GetAll();
    Task<IEnumerable<Commentaries>> GetByFixtureId(int id);
}