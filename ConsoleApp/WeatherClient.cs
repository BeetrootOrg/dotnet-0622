using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp;

internal class WeaterResponse
{
    [JsonProperty("temperature")]
    public string Temperature {get;init;}

    [JsonProperty("windspeed")]
    public string WindSpeed {get;init;}

    [JsonProperty("winddirection")]
    public string WindDirection {get;init;}
}

internal interface IWeaterClient
{
    Task<WeaterResponse> GetWeather(CancellationToken cancellationToken = default);
}

internal class WeaterClient : IWeaterClient
{
    private readonly HttpClient _httpClient;
    private string _lat = "50.41";
    private string _lon = "30.51";

    public WeaterClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public WeaterClient(HttpClient httpClient, string lat, string lon)
    {
        _httpClient = httpClient;
        _lat = lat;
        _lon = lon;
    }

    public async Task<WeaterResponse> GetWeather(CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync($"/v1/forecast?latitude={_lat}&longitude={_lon}&current_weather=true", cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        JObject weather = JObject.Parse(content);
        var temperature = weather["current_weather"]["temperature"];
        var windSpeed = weather["current_weather"]["windspeed"];
        var windDirection = weather["current_weather"]["winddirection"];
        var a = JsonConvert.DeserializeObject<WeaterResponse>($"{{\"temperature\":\"{temperature}\",\"windspeed\":\"{windSpeed}\",\"winddirection\":\"{windDirection}\"}}");
        return a;
    }
}