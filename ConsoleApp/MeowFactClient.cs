using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class MeowFactResponse
{
    [JsonProperty("data")]
    public string[] MeowFact { get; init; }
}

internal interface IMeowFactClient
{
    Task<MeowFactResponse> GetRandomMeowFact(CancellationToken cancellationToken = default);
}

internal class MeowFactClient : IMeowFactClient
{
    private readonly HttpClient _httpClient;

    public MeowFactClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<MeowFactResponse> GetRandomMeowFact(CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync("", cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<MeowFactResponse>(content);
    }
}