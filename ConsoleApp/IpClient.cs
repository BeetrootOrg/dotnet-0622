using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConsoleApp;

internal class IpResponseWrapper
{
    [JsonProperty("ip")]
    public string Ip { get; init; }
}

internal interface IIpClient
{
    Task<IpResponseWrapper> GetCurrentIp(CancellationToken cancellationToken = default);
}

internal class IpClient : IIpClient
{
    private readonly HttpClient _httpClient;

    public IpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IpResponseWrapper> GetCurrentIp(CancellationToken cancellationToken = default)
    {
        using HttpResponseMessage response = await _httpClient.GetAsync("?format=json", cancellationToken);
        response.EnsureSuccessStatusCode();

        string content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<IpResponseWrapper>(content);
    }
}