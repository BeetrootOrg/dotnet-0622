using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class WaifuResponse
{
    [JsonProperty("images")]
    public WaifuImageLink[] Images { get; init; }
    internal class WaifuImageLink
    {
        [JsonProperty("url")]
        public string Url { get; init; }

        [JsonProperty("extension")]
        public string Extension { get; init; }
    }
}

internal interface IWaifuClient
{
    Task<WaifuResponse> GetRandomWaifu(CancellationToken cancellationToken = default);
    Task<Stream> GetImage(string image, CancellationToken cancellationToken = default);
}

internal class WaifuClient : IWaifuClient
{
    private readonly HttpClient _httpClient;

    public WaifuClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Stream> GetImage(string imageUrl, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync(imageUrl, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStreamAsync(cancellationToken);
    }

    public async Task<WaifuResponse> GetRandomWaifu(CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync("/random?is_nsfw=false", cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<WaifuResponse>(content);
    }
}