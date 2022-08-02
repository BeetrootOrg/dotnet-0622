using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class Weather
{
    [JsonProperty("temperature")]
    public string Temperature { get; init; }

    [JsonProperty("windspeed")]
    public string WindSpeed { get; init; }

    [JsonProperty("winddirection")]
    public string WindDirection { get; init; }
}

internal class WeatherResponse
{
    [JsonProperty("current_weather")]
    public Weather CurrentWeather { get; set; }
}

internal interface IWeatherClient
{
    Task<Weather> GetWeather(string latitude, string longitude, CancellationToken cancellationToken = default);
}

internal class WeatherClient : IWeatherClient
{
    private readonly HttpClient _httpClient;

    public WeatherClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Weather> GetWeather(string latitude, string longitude, CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync($"/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true", cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        var result = JsonConvert.DeserializeObject<WeatherResponse>(content);
        return result?.CurrentWeather;
    }
}