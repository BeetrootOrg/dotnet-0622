using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class FactResponse
{
    [JsonProperty("text")]
    public string Text { get; set; }
}

internal interface IFactClient
{
    Task<FactResponse> GetRandomFact();
}

internal class FactClient : IFactClient
{
    private readonly HttpClient _httpClient;

    public FactClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<FactResponse> GetRandomFact()
    {
        var response = await _httpClient.GetAsync("random.json");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<FactResponse>(content);
    }
}