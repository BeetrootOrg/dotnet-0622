using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Drawing;
using Newtonsoft.Json;
using System.Net;

namespace ConsoleApp;

internal class FoxResponse
{
    [JsonProperty("image")]
    public string Image { get; set; }
}

internal interface IFoxClient
{
    Task<FoxResponse> GetRandomFox(CancellationToken cancellationToken = default);
    Task GetImage(string image);
}

internal class FoxClient : IFoxClient
{
    private readonly HttpClient _httpClient;
    public FoxClient(HttpClient httpclient)
    {
        _httpClient = httpclient;
    }

    public async Task<FoxResponse> GetRandomFox(CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync("/api", cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonConvert.DeserializeObject<FoxResponse>(content);
    }
    public async Task GetImage(string imageLink)
    {
        using (WebClient client = new WebClient())
        {
            client.DownloadFile(new Uri(imageLink), @"D:\Study\C#\dotnet-0622\ConsoleApp\foxImage.jpg");
        }
    }
}