using StatGenius.Common.DataObjects;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.Web.Api.Contracts.Responses;

public class GetAllFixturesResponse
{
    public IEnumerable<FixturesDto> Fixtures { get; init; } = Enumerable.Empty<FixturesDto>();
}