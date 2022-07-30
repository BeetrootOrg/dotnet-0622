using System;
using System.IO;
using System.Net.Http;

using static System.Console;

using ConsoleApp;
using System.Threading;

using var cancellationTokenSource = new CancellationTokenSource();
// analogue to above
CancellationTokenSource cancellationTokenSource2 = default;
try
{
    cancellationTokenSource2 = new CancellationTokenSource();
    // work with it
}
finally
{
    cancellationTokenSource2?.Dispose();
    // the above equivalent to
    // if (cancellationTokenSource2 != null)
    // {
    //     cancellationTokenSource2.Dispose();
    // }
}
var cancellationToken = cancellationTokenSource.Token;

Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) =>
{
    cancellationTokenSource.Cancel();
};

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://foodish-api.herokuapp.com"),
    Timeout = TimeSpan.FromSeconds(5)
};

var foodClient = new FoodClient(httpClient);

var result = await foodClient.GetRandomFood(cancellationToken);
WriteLine("Random image generated!");

using var stream = await foodClient.GetImage(result.Image, cancellationToken);
WriteLine("Image received!");

using var fileStream = File.OpenWrite("food.jpg");
await stream.CopyToAsync(fileStream, cancellationToken);
WriteLine("Image saved!");