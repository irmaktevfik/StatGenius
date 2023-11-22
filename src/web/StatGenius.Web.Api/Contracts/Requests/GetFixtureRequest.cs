namespace StatGenius.Web.Api.Contracts.Requests;

public class GetFixtureRequest
{
    public int? Id { get; init; }
    public int[]? Ids { get; init; }
    public DateTime? Date { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? TeamId { get; set; }
    public int? TeamId1 { get; set; }
    public int? TeamId2 { get; set; }
    public string? SearchQuery { get; set; }
}