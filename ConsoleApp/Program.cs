using static System.Console;
using ConsoleApp;


using var cancellationTokenSource = new CancellationTokenSource();

var cancellationToken = cancellationTokenSource.Token;

Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) =>
{
    cancellationTokenSource.Cancel();
};

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://meowfacts.herokuapp.com/"),
    Timeout = TimeSpan.FromSeconds(5)
};

var factClient = new FactClient(httpClient);

var result = await factClient.GetRandomFact(cancellationToken);
WriteLine("Fact generated!");

WriteLine(result.Fact[0]);