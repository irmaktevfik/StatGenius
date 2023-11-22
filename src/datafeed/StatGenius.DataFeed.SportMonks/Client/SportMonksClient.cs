using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace StatGenius.DataFeed.Models.Client;

public abstract class SportMonksClient
{
    private static HttpClient _httpClient;
    public SportMonksClient(SportMonksFeedTypes sportMonksFeedType)
    {
        PrepareClient(sportMonksFeedType);
    }

    private static void PrepareClient(SportMonksFeedTypes sportMonksFeedType)
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = sportMonksFeedType switch
        {
            SportMonksFeedTypes.Football => new Uri("https://api.sportmonks.com/v3/football/"),
            SportMonksFeedTypes.Core => new Uri("https://api.sportmonks.com/v3/core/"),
            SportMonksFeedTypes.Odds => new Uri("https://api.sportmonks.com/v3/odds/"),
            _ => throw new ArgumentOutOfRangeException()
        };
        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("your auth key");
    }
    
    protected async Task<IEnumerable<T>> GetListAsync<T>(string feedUrl)
    {
        var response = await _httpClient.GetAsync(feedUrl);
        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content?.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(responseString))
            {
                if (responseString.Contains("No result(s) found matching your request"))
                    return Enumerable.Empty<T>();            

                // Deserialize JSON into a list of Types using an anonymous type
                var anonymousType = new { data = new List<T>() };
                return JsonConvert.DeserializeAnonymousType(responseString, anonymousType).data;    
            }
        }
        return Enumerable.Empty<T>();
    }
    protected async Task<T> GetSingleAsync<T>(string feedUrl)
    {
        var response = await _httpClient.GetAsync(feedUrl);
        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content?.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(responseString))
            {
                return JsonConvert.DeserializeObject<T>(responseString);
            }
        }
        return default(T);
    }
}