namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class Probabilities
{
    public int id { get; set; }
    public int fixture_id { get; set; }
    public int type_id { get; set; }
    public Predictions predictions { get; set; }
    public Predictions data { get; set; }

}