namespace StatGenius.Web.Api.Contracts.Requests;

public class GetBookmakerRequest
{
    public int Id { get; init; }
    public int RequestId { get; init; }
    public string SearchQuery { get; init; }
}