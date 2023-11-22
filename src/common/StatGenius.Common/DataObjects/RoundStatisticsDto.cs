namespace StatGenius.Common.DataObjects;

public class RoundStatisticsDto
{
    public int id { get; set; }
    public int model_id { get; set; }
    public int type_id { get; set; }
    public object relation_id { get; set; }
    public RoundStatisticValuesDto valueDto { get; set; }
}