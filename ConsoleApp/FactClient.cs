using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class FactClient : IFactClient
{
    private readonly HttpClient _httpClient;

    public FactClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<FactResponse> GetRandomFact(CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync("", cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<FactResponse>(content);
    }
}