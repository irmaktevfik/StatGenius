namespace StatGenius.Common.DataObjects;

public class ProbabilitiesDto
{
    public int id { get; set; }
    public int fixture_id { get; set; }
    public int type_id { get; set; }
    public PredictionsDto predictionsDto { get; set; }
    public PredictionsDto data { get; set; }

}