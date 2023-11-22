namespace StatGenius.Data.Sql.Models;

public class SeasonStatisticDetails
{
    public int id { get; set; }
    public int player_statistic_id { get; set; }
    public int type_id { get; set; }
    public SeasonStatisticDetailValues value { get; set; }
}