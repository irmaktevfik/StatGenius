namespace StatGenius.Web.Api.Contracts.Responses;

public class GetTypeResponse
{
    public int id { get; init; }
    
    public string name { get; init; } = default!;
    
    public string code { get; init; } = default!;
    
    public string developer_name { get; init; }
    
    public string model_type { get; init; }
    
    public string? stat_group { get; init; }
}