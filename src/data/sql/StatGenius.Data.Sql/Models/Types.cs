namespace StatGenius.Data.Sql.Models;

public class Types
{
    public int id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public string developer_name { get; set; }
    public string model_type { get; set; }
    public string? stat_group { get; set; }
}