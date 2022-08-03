using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class FactResponse
{
    [JsonProperty("data")]
    public string[] Fact { get; init; }
}

internal interface IClient
{
    Task<FactResponse> GetRandomFact(CancellationToken cancellationToken = default);
}

internal class MeowClient : IClient
{
    private readonly HttpClient _httpClient;

    public MeowClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<FactResponse> GetRandomFact(CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync("/api", cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<FactResponse>(content);
    }
}

