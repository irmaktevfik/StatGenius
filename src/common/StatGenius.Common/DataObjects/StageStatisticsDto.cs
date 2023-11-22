namespace StatGenius.Common.DataObjects;

public class StageStatisticsDto
{
    public int id { get; set; }
    public int model_id { get; set; }
    public int type_id { get; set; }
    public int? relation_id { get; set; }
    public StageStatisticsValuesDto valueDto { get; set; }
}