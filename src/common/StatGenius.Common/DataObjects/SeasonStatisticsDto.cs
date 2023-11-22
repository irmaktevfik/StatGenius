namespace StatGenius.Common.DataObjects;

public class SeasonStatisticsDto
{
    public int id { get; set; }
    public int player_id { get; set; }
    public int team_id { get; set; }
    public int season_id { get; set; }
    public bool has_values { get; set; }
    public int position_id { get; set; }
    public int jersey_number { get; set; }
    public List<SeasonStatisticDetailsDto> details { get; set; }
}