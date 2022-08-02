namespace ConsoleApp;

internal interface IFactClient
{
    Task<FactResponse> GetRandomFact(CancellationToken cancellationToken = default);
}