using System;
using System.IO;
using System.Net.Http;

using static System.Console;

using ConsoleApp;
using System.Threading;

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

var meowClient = new MeowClient(httpClient);

var result = await meowClient.GetRandomFact(cancellationToken);
WriteLine("Random fact generated!");

