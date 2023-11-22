namespace StatGenius.Common.DataObjects;

public class SeasonStatisticDetailsDto
{
    public int id { get; set; }
    public int player_statistic_id { get; set; }
    public int type_id { get; set; }
    public SeasonStatisticDetailValuesDto valueDto { get; set; }
}