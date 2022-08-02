namespace ConsoleApp;
using Newtonsoft.Json;

internal class FactResponse
{
    [JsonProperty("data")]
    public string[] Fact { get; init; }
}