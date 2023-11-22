using StatGenius.Common.DataObjects;

namespace StatGenius.Web.Api.Contracts.Responses;

public class GetAllCoachesResponse
{
    public IEnumerable<CoachesDto> Coaches { get; init; } = Enumerable.Empty<CoachesDto>();
}