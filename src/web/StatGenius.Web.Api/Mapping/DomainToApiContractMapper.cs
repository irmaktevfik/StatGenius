using StatGenius.Common.DataObjects;
using StatGenius.DataFeed.SportMonks.Football.Models;
using StatGenius.Web.Api.Contracts.Responses;

namespace StatGenius.Web.Api.Mapping;

public class DomainToApiContractMapper : BaseMapper
{
    #region Types

    public GetAllTypesResponse ToTypesResponse(IEnumerable<Types> types)
    {
        return new GetAllTypesResponse
        {
            Types = _mapper.Map<List<TypesDto>>(types)
        };
    }

    public GetTypeResponse ToTypesResponse(Types types)
    {
        return new GetTypeResponse
        {
            name = types.name,
            code = types.code,
            developer_name = types.developer_name,
            id = types.id,
            model_type = types.model_type,
            stat_group = types.stat_group
        };
    }

    #endregion

    #region Bookmakers

    public GetAllBookmakersResponse ToBookmakersResponse(IEnumerable<Bookmakers> bookmakers)
    {
        return new GetAllBookmakersResponse
        {
            Bookmakers = _mapper.Map<List<BookmakersDto>>(bookmakers)
        };
    }

    public GetBookmakersResponse ToBookmakersResponse(Bookmakers bookmakers)
    {
        return new GetBookmakersResponse
        {
            name = bookmakers.name,
            legacy_id = bookmakers.legacy_id,
            id = bookmakers.id,
        };
    }

    #endregion

    #region Coaches

    public GetAllCoachesResponse ToCoachesResponse(IEnumerable<Coaches> coaches)
    {
        return new GetAllCoachesResponse()
        {
            Coaches = _mapper.Map<List<CoachesDto>>(coaches)
        };
    }

    public GetCoachResponse ToCoachesResponse(Coaches coaches)
    {
        return new GetCoachResponse()
        {
            name = coaches.name,
            player_id = coaches.player_id,
            sport_id = coaches.sport_id,
            country_id = coaches.country_id,
            nationality_id = coaches.nationality_id,
            city_id = coaches.city_id,
            common_name = coaches.name,
            firstname = coaches.firstname,
            lastname = coaches.lastname,
            display_name = coaches.display_name,
            image_path = coaches.image_path,
            height = coaches.height,
            weight = coaches.weight,
            date_of_birth = coaches.date_of_birth,
            gender = coaches.gender,
            id = coaches.id,
        };
    }

    #endregion

    #region Commentaries

    public GetAllCommentariesResponse ToCommentariesResponse(IEnumerable<Commentaries> commentaries)
    {
        return new GetAllCommentariesResponse()
        {
            Commentaries = _mapper.Map<List<CommentariesDto>>(commentaries)
        };
    }

    #endregion

    #region Fixtures

    public GetAllFixturesResponse ToFixturesResponse(IEnumerable<Fixtures> fixtures)
    {
        return new GetAllFixturesResponse()
        {
            Fixtures = _mapper.Map<List<FixturesDto>>(fixtures)
        };
    }

    public GetFixturesResponse ToFixturesResponse(Fixtures fixtures)
    {
        return new GetFixturesResponse()
        {
            id = fixtures.id,
            sport_id = fixtures.sport_id,
            league_id = fixtures.league_id,
            season_id = fixtures.season_id,
            stage_id = fixtures.stage_id,
            group_id = fixtures.group_id,
            aggregate_id = fixtures.aggregate_id,
            round_id = fixtures.round_id,
            state_id = fixtures.state_id,
            venue_id = fixtures.venue_id,
            name = fixtures.name,
            starting_at = fixtures.starting_at,
            result_info = fixtures.result_info,
            leg = fixtures.leg,
            details = fixtures.details,
            length = fixtures.length,
            placeholder = fixtures.placeholder,
            has_odds = fixtures.has_odds,
            starting_at_timestamp = fixtures.starting_at_timestamp,
            participants = _mapper.Map<List<ParticipantsDto>>(fixtures.participants),
            scores = _mapper.Map<List<ScoresDto>>(fixtures.scores),
        };
    }

    #endregion
}