namespace StatGenius.Web.Api.Contracts.Responses;

public class GetBookmakersResponse
{
    public int id { get; init; } = default!;
    public int legacy_id { get; set; }
    public string name { get; set; } = default!;
}