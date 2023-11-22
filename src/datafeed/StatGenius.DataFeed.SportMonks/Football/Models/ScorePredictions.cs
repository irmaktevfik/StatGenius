using Newtonsoft.Json;

namespace StatGenius.DataFeed.SportMonks.Football.Models;

public class ScorePredictions
{
    [JsonProperty("0-0")]
    public double _00 { get; set; }

    [JsonProperty("0-1")]
    public double _01 { get; set; }

    [JsonProperty("0-2")]
    public double _02 { get; set; }

    [JsonProperty("0-3")]
    public double _03 { get; set; }

    [JsonProperty("1-0")]
    public double _10 { get; set; }

    [JsonProperty("1-1")]
    public double _11 { get; set; }

    [JsonProperty("1-2")]
    public double _12 { get; set; }

    [JsonProperty("1-3")]
    public double _13 { get; set; }

    [JsonProperty("2-0")]
    public double _20 { get; set; }

    [JsonProperty("2-1")]
    public double _21 { get; set; }

    [JsonProperty("2-2")]
    public double _22 { get; set; }

    [JsonProperty("2-3")]
    public double _23 { get; set; }

    [JsonProperty("3-0")]
    public double _30 { get; set; }

    [JsonProperty("3-1")]
    public double _31 { get; set; }

    [JsonProperty("3-2")]
    public double _32 { get; set; }

    [JsonProperty("3-3")]
    public double _33 { get; set; }
    public double Other_1 { get; set; }
    public double Other_2 { get; set; }
    public double Other_X { get; set; }
}