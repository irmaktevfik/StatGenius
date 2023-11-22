namespace StatGenius.Common.DataObjects;

public class StageStatisticsValuesDto
{
    public int total { get; set; }
    public int? count { get; set; }
    public double? percentage { get; set; }
    public int? participant_id { get; set; }
    public string participant_name { get; set; }
    public int? participant_count { get; set; }
    public double? all { get; set; }
    public double? home { get; set; }
    public double? away { get; set; }
}