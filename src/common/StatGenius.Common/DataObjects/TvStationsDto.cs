namespace StatGenius.Common.DataObjects;

public class TvStationsDto
{
    public int id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public string image_path { get; set; }
    public string type { get; set; }
    public int? related_id { get; set; }
}