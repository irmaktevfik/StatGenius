namespace StatGenius.Data.Sql.Models;

public class Venues
{
    public int id { get; set; }
    public int country_id { get; set; }
    public int city_id { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public object zipcode { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }
    public int capacity { get; set; }
    public string image_path { get; set; }
    public string city_name { get; set; }
    public string surface { get; set; }
    public bool national_team { get; set; }
}