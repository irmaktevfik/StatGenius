namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class Standings
{
    public int participant_id { get; set; }
    public int sport_id { get; set; }
    public int league_id { get; set; }
    public int season_id { get; set; }
    public int stage_id { get; set; }
    public string? group_id { get; set; }
    public int round_id { get; set; }
    public int standing_rule_id { get; set; }
    public int position { get; set; }
    public string result { get; set; }
    public int points { get; set; }
}