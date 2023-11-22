namespace StatGenius.Data.Sql.Models;

public class Commentaries
{
    public int id { get; set; }
    public int fixture_id { get; set; }
    public string comment { get; set; }
    public int? minute { get; set; }
    public object extra_minute { get; set; }
    public bool is_goal { get; set; }
    public bool is_important { get; set; }
    public int order { get; set; }
}