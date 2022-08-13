using System;
using System.IO;
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
    BaseAddress = new Uri("https://foodish-api.herokuapp.com"),
    Timeout = TimeSpan.FromSeconds(5)
};

var foodClient = new FoodClient(httpClient);

var result = await foodClient.GetRandomFood(cancellationToken);
WriteLine("Random image generated");

using var stream = await foodClient.GetImage(result.Image, cancellationToken);
WriteLine("Image received");

using var fileStream = File.OpenWrite("food.jpg");
await stream.CopyToAsync(fileStream, cancellationToken);
WriteLine("Image saved");
