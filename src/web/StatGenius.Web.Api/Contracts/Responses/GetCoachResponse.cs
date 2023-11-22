namespace StatGenius.Web.Api.Contracts.Responses;

public class GetCoachResponse
{
    public int id { get; init; }
    public int player_id { get; init; }
    public int sport_id { get; init; }
    public int country_id { get; init; }
    public int? nationality_id { get; init; }
    public int? city_id { get; init; }
    public string common_name { get; init; }
    public string firstname { get; init; }
    public string lastname { get; init; }
    public string name { get; init; }
    public string display_name { get; init; }
    public string image_path { get; init; }
    public int? height { get; init; }
    public int? weight { get; init; }
    public string date_of_birth { get; init; }
    public string gender { get; init; }
}