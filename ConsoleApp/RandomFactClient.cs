using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class RandomFactResponse
{
    [JsonProperty("text")]
    public string Fact { get; init; }
}

internal interface IRandomFactClient
{
    Task<RandomFactResponse> GetRandomFact(string path, CancellationToken cancellationToken = default);
}

internal class RandomFactClient : IRandomFactClient
{
    private readonly HttpClient _httpClient;

    public RandomFactClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<RandomFactResponse> GetRandomFact(string path, CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync(path, cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<RandomFactResponse>(content);
    }
}