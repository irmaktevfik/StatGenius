using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.DataFeed.Models.Repository.Implementation;

public interface ILiveScoresRepository
{
    Task<IEnumerable<LiveScores>> GetInplay();
    Task<IEnumerable<LiveScores>> GetAll();
    Task<IEnumerable<LiveScores>> GetLatestUpdated();
}


















































