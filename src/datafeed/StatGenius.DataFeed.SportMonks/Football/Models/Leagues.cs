namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class Leagues
{
    public int id { get; set; }
    public int sport_id { get; set; }
    public int country_id { get; set; }
    public string name { get; set; }
    public bool active { get; set; }
    public string? short_code { get; set; }
    public string image_path { get; set; }
    public string type { get; set; }
    public string sub_type { get; set; }
    public string last_played_at { get; set; }
    public int category { get; set; }
    public bool has_jerseys { get; set; }
}