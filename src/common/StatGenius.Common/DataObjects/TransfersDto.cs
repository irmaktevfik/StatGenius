namespace StatGenius.Common.DataObjects;

public class TransfersDto
{
    public int id { get; set; }
    public int sport_id { get; set; }
    public int player_id { get; set; }
    public int type_id { get; set; }
    public int from_team_id { get; set; }
    public int to_team_id { get; set; }
    public int position_id { get; set; }
    public int detailed_position_id { get; set; }
    public string date { get; set; }
    public bool career_ended { get; set; }
    public bool completed { get; set; }
    public int? amount { get; set; }
}