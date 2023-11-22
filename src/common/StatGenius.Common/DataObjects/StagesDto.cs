namespace StatGenius.Common.DataObjects;
public class StagesDto
{
    public int id { get; set; }
    public int sport_id { get; set; }
    public int league_id { get; set; }
    public int season_id { get; set; }
    public int type_id { get; set; }
    public string name { get; set; }
    public int sort_order { get; set; }
    public bool finished { get; set; }
    public bool is_current { get; set; }
    public string starting_at { get; set; }
    public string ending_at { get; set; }
    public bool games_in_current_week { get; set; }
}