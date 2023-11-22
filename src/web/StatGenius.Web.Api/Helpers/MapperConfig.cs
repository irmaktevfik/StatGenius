using AutoMapper;
using StatGenius.Common.DataObjects;
using StatGenius.DataFeed.SportMonks.Football.Models;


namespace StatGenius.Web.Api.Helpers;

public static class MapperConfig
{
    public static MapperConfiguration GetMapperConfig()
    {
        return new MapperConfiguration(config =>
        {
            config.CreateMap<TypesDto, Types>();
            config.CreateMap<Types, TypesDto>();
            config.CreateMap<BookmakersDto, Bookmakers>();
            config.CreateMap<Bookmakers, BookmakersDto>();
            config.CreateMap<CoachesDto, Coaches>();
            config.CreateMap<Coaches, CoachesDto>();
            config.CreateMap<CommentariesDto, Commentaries>();
            config.CreateMap<Commentaries, CommentariesDto>();
            config.CreateMap<FixturesDto, Fixtures>();
            config.CreateMap<Fixtures, FixturesDto>();    
            config.CreateMap<InplayOddsDto, InplayOdds>();
            config.CreateMap<InplayOdds, InplayOddsDto>();    
            config.CreateMap<LeaguesDto, Leagues>();
            config.CreateMap<Leagues, LeaguesDto>();    
            config.CreateMap<LiveScoresDto, LiveScores>();
            config.CreateMap<LiveScores, LiveScoresDto>();    
            config.CreateMap<MarketsDto, Markets>();
            config.CreateMap<Markets, MarketsDto>();    
            config.CreateMap<ParticipantDetailsDto, ParticipantDetails>();
            config.CreateMap<ParticipantDetails, ParticipantDetailsDto>();    
            config.CreateMap<ParticipantsDto, Participants>();
            config.CreateMap<Participants, ParticipantsDto>();    
            config.CreateMap<PlayersDto, Players>();
            config.CreateMap<Players, PlayersDto>();    
            config.CreateMap<PredictionsDto, Predictions>();
            config.CreateMap<Predictions, PredictionsDto>();    
            config.CreateMap<PreMatchNewsDto, PreMatchNews>();
            config.CreateMap<PreMatchNews, PreMatchNewsDto>();    
            config.CreateMap<PreMatchOddsDto, PreMatchOdds>();
            config.CreateMap<PreMatchOdds, PreMatchOddsDto>();    
            config.CreateMap<ProbabilitiesDto, Probabilities>();
            config.CreateMap<Probabilities, ProbabilitiesDto>();    
            config.CreateMap<RefereesDto, Referees>();
            config.CreateMap<Referees, RefereesDto>();    
            config.CreateMap<RivalsDto, Rivals>();
            config.CreateMap<Rivals, RivalsDto>();    
            config.CreateMap<RoundsDto, Rounds>();
            config.CreateMap<Rounds, RoundsDto>();    
            config.CreateMap<RoundStatisticsDto, RoundStatistics>();
            config.CreateMap<RoundStatistics, RoundStatisticsDto>();    
            config.CreateMap<RoundStatisticValuesDto, RoundStatisticValues>();
            config.CreateMap<RoundStatisticValues, RoundStatisticValuesDto>();    
            config.CreateMap<SchedulesDto, Schedules>();
            config.CreateMap<Schedules, SchedulesDto>();    
            config.CreateMap<ScoreDto, Score>();
            config.CreateMap<Score, ScoreDto>();    
            config.CreateMap<ScorePredictionsDto, ScorePredictions>();
            config.CreateMap<ScorePredictions, ScorePredictionsDto>();    
            config.CreateMap<ScoresDto, Scores>();
            config.CreateMap<Scores, ScoresDto>();    
            config.CreateMap<SeasonsDto, Seasons>();
            config.CreateMap<Seasons, SeasonsDto>();    
            config.CreateMap<SeasonStatisticDetailsDto, SeasonStatisticDetails>();
            config.CreateMap<SeasonStatisticDetails, SeasonStatisticDetailsDto>();    
            config.CreateMap<SeasonStatisticDetailValuesDto, SeasonStatisticDetailValues>();
            config.CreateMap<SeasonStatisticDetailValues, SeasonStatisticDetailValuesDto>();    
            config.CreateMap<SeasonStatisticsDto, SeasonStatistics>();
            config.CreateMap<SeasonStatistics, SeasonStatisticsDto>();    
            config.CreateMap<StagesDto, Stages>();
            config.CreateMap<Stages, StagesDto>();    
            config.CreateMap<StageStatisticsDto, StageStatistics>();
            config.CreateMap<StageStatistics, StageStatisticsDto>();    
            config.CreateMap<StageStatisticsValuesDto, StageStatisticsValues>();
            config.CreateMap<StageStatisticsValues, StageStatisticsValuesDto>();    
            config.CreateMap<StandingsDto, Standings>();
            config.CreateMap<Standings, StandingsDto>();    
            config.CreateMap<StatesDto, States>();
            config.CreateMap<States, StatesDto>();    
            config.CreateMap<TeamsDto, Teams>();
            config.CreateMap<Teams, TeamsDto>();    
            config.CreateMap<TeamSquadsDto, TeamSquads>();
            config.CreateMap<TeamSquads, TeamSquadsDto>();    
            config.CreateMap<TopScorrersDto, TopScorrers>();
            config.CreateMap<TopScorrers, TopScorrersDto>();    
            config.CreateMap<TransfersDto, Transfers>();
            config.CreateMap<Transfers, TransfersDto>();    
            config.CreateMap<TvStationsDto, TvStations>();
            config.CreateMap<TvStations, TvStationsDto>();    
            config.CreateMap<VenuesDto, Venues>();
            config.CreateMap<Venues, VenuesDto>();    
        });
    }
}