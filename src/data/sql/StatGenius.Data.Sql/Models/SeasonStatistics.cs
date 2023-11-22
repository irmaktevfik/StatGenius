namespace StatGenius.Data.Sql.Models;

public class SeasonStatistics
{
    public int id { get; set; }
    public int player_id { get; set; }
    public int team_id { get; set; }
    public int season_id { get; set; }
    public bool has_values { get; set; }
    public int position_id { get; set; }
    public int jersey_number { get; set; }
    public List<SeasonStatisticDetails> details { get; set; }
}