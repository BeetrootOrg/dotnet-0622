using System;
using System.Net.Http;
using static System.Console;

using ConsoleApp;
using System.Threading;

using var cancellationTokenSourse = new CancellationTokenSource();
var cancellationToken = cancellationTokenSourse.Token;

Console.CancelKeyPress += (object? sender, ConsoleCancelEventArgs e) =>
{
    cancellationTokenSourse.Cancel();
};

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://meowfacts.herokuapp.com/"),
    Timeout = TimeSpan.FromSeconds(5)
};

var factClient = new FactClient(httpClient);
WriteLine("Random meowfacts generation!");
var result = await factClient.GetRandomFact(cancellationToken);
WriteLine($"Random meowfacts generated: {result.Data[0]}");