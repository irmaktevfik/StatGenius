namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class RoundStatistics
{
    public int id { get; set; }
    public int model_id { get; set; }
    public int type_id { get; set; }
    public object relation_id { get; set; }
    public RoundStatisticValues value { get; set; }
}