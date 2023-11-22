namespace StatGenius.Common.DataObjects;

public class RefereesDto
{
    public int id { get; set; }
    public int sport_id { get; set; }
    public int? country_id { get; set; }
    public int? city_id { get; set; }
    public string common_name { get; set; }
    public string? firstname { get; set; }
    public string? lastname { get; set; }
    public string name { get; set; }
    public string display_name { get; set; }
    public string image_path { get; set; }
    public int? height { get; set; }
    public int? weight { get; set; }
    public string? date_of_birth { get; set; }
    public string? gender { get; set; }
}