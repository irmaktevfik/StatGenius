using StatGenius.Common.DataObjects;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.Web.Api.Contracts.Responses;

public class GetAllBookmakersResponse
{
    public IEnumerable<BookmakersDto> Bookmakers { get; init; } = Enumerable.Empty<BookmakersDto>();
}