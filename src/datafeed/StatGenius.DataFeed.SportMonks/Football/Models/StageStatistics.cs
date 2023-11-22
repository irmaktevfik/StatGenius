namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class StageStatistics
{
    public int id { get; set; }
    public int model_id { get; set; }
    public int type_id { get; set; }
    public int? relation_id { get; set; }
    public StageStatisticsValues value { get; set; }
}