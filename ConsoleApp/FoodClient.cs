using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class FoodResponse
{
    [JsonProperty("image")]
    public string Image { get; init; }
}

internal interface IFoodClient
{
    Task<FoodResponse> GetRandomFood(CancellationToken cancellationToken = default);
    Task<Stream> GetImage(string image, CancellationToken cancellationToken = default);
}

internal class FoodClient : IFoodClient
{
    private readonly HttpClient _httpClient;

    public FoodClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<FoodResponse> GetRandomFood(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("/api", cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<FoodResponse>(content);
    }

    public async Task<Stream> GetImage(string imageUrl, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync(imageUrl, cancellationToken);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStreamAsync(cancellationToken);
    }
}