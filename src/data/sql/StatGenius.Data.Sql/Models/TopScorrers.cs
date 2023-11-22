namespace StatGenius.Data.Sql.Models;

public class TopScorrers
{
    public int id { get; set; }
    public int season_id { get; set; }
    public int player_id { get; set; }
    public int type_id { get; set; }
    public int position { get; set; }
    public int total { get; set; }
    public int participant_id { get; set; }
}