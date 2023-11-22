namespace StatGenius.Data.Sql.Models;

public class Fixtures
{
    public int id { get; set; }
    public int sport_id { get; set; }
    public int league_id { get; set; }
    public int season_id { get; set; }
    public int stage_id { get; set; }
    public int? group_id { get; set; }
    public int? aggregate_id { get; set; }
    public int? round_id { get; set; }
    public int state_id { get; set; }
    public int? venue_id { get; set; }
    public string? name { get; set; }
    public string? starting_at { get; set; }
    public string? result_info { get; set; }
    public string leg { get; set; }
    public string? details { get; set; }
    public int? length { get; set; }
    public bool placeholder { get; set; }
    public bool has_odds { get; set; }
    public int starting_at_timestamp { get; set; }
    public List<Participants> participants { get; set; }
    public List<Scores> scores { get; set; }
}