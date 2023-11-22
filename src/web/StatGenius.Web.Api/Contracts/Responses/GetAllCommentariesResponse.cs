using StatGenius.Common.DataObjects;
using StatGenius.DataFeed.SportMonks.Football.Models;

namespace StatGenius.Web.Api.Contracts.Responses;

public class GetAllCommentariesResponse
{
    public IEnumerable<CommentariesDto> Commentaries { get; init; } = Enumerable.Empty<CommentariesDto>();
}