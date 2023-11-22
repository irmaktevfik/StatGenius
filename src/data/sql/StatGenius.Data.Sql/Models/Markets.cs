namespace StatGenius.Data.Sql.Models;

public class Markets
{
    public int id { get; set; }
    public int? legacy_id { get; set; }
    public string name { get; set; }
    public string developer_name { get; set; }
    public bool has_winning_calculations { get; set; }
}