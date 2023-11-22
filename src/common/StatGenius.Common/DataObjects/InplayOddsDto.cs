namespace StatGenius.Common.DataObjects;

public class InplayOddsDto
{
    public int id { get; set; }
    public int fixture_id { get; set; }
    public int market_id { get; set; }
    public int bookmaker_id { get; set; }
    public string label { get; set; }
    public string value { get; set; }
    public string name { get; set; }
    public int sort_order { get; set; }
    public string market_description { get; set; }
    public string probability { get; set; }
    public string dp3 { get; set; }
    public string fractional { get; set; }
    public string american { get; set; }
    public bool winning { get; set; }
    public bool suspended { get; set; }
    public bool stopped { get; set; }
    public object total { get; set; }
    public object handicap { get; set; }
    public string participants { get; set; }
    public object latest_bookmaker_update { get; set; }
}