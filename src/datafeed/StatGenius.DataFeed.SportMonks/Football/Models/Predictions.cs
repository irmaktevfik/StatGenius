namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class Predictions
{
    public double yes { get; set; }
    public double no { get; set; }
    public string fulltime_result { get; set; }
    public object away_over_under_0_5 { get; set; }
    public object away_over_under_1_5 { get; set; }
    public string both_teams_to_score { get; set; }
    public string team_to_score_first { get; set; }
    public object home_over_under_0_5 { get; set; }
    public object home_over_under_1_5 { get; set; }
    public string over_under_1_5 { get; set; }
    public string over_under_2_5 { get; set; }
    public string over_under_3_5 { get; set; }
    public string correct_score { get; set; }
    public string ht_ft { get; set; }
    public string fulltime_result_1st_half { get; set; }
    public int id { get; set; }
    public int league_id { get; set; }
    public int type_id { get; set; }
    public string bet { get; set; }
    public string bookmaker { get; set; }
    public double odd { get; set; }
    public bool is_value { get; set; }
    public double stake { get; set; }
    public double fair_odd { get; set; }
    public ScorePredictions scores { get; set; }
}