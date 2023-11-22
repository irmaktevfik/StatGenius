namespace StatGenius.Data.Sql.Models;

public class Teams
{
    public int id { get; set; }
    public int sport_id { get; set; }
    public int country_id { get; set; }
    public int venue_id { get; set; }
    public string gender { get; set; }
    public string name { get; set; }
    public string short_code { get; set; }
    public string image_path { get; set; }
    public int founded { get; set; }
    public string type { get; set; }
    public bool placeholder { get; set; }
    public string last_played_at { get; set; }
}