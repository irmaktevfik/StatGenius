namespace StatGenius.Common.DataObjects;

public class ScoresDto
{
    public int id { get; set; }
    public int fixture_id { get; set; }
    public int type_id { get; set; }
    public int participant_id { get; set; }
    public ScoreDto scoreDto { get; set; }
    public string description { get; set; }
}