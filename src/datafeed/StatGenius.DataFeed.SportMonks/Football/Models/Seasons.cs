namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class Seasons
{
    public int id { get; set; }
    public int sport_id { get; set; }
    public int league_id { get; set; }
    public int tie_breaker_rule_id { get; set; }
    public string name { get; set; }
    public bool finished { get; set; }
    public bool pending { get; set; }
    public bool is_current { get; set; }
    public string starting_at { get; set; }
    public string ending_at { get; set; }
    public string standings_recalculated_at { get; set; }
    public bool games_in_current_week { get; set; }
}