namespace StatGenius.Web.Api.Contracts.Requests;

public class GetCoachesRequest
{
    public int Id { get; init; }
    public int CountryId { get; init; }
    public string SearchQuery { get; init; }
}