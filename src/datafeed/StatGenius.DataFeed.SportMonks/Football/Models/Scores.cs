namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class Scores
{
    public int id { get; set; }
    public int fixture_id { get; set; }
    public int type_id { get; set; }
    public int participant_id { get; set; }
    public Score score { get; set; }
    public string description { get; set; }
}