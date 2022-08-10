using System.Threading.Tasks;

namespace ConsoleApp;

internal class FactResponse
{
    public string Data { get; set; }
}

internal interface IFactClient
{
    Task<FactResponse> GetRandomFact();
}

internal class FactClient : IFactClient
{
    public Task<FactResponse> GetRandomFact()
    {
        throw new System.NotImplementedException();
    }
}