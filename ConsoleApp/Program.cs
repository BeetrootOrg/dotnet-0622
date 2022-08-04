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
    BaseAddress = new Uri("https://api.waifu.im/")
};

var waifuClient = new WaifuClient(httpClient);

var result = await waifuClient.GetRandomWaifu(cancellationToken);
WriteLine("Your waifu was found!");

using var stream = await waifuClient.GetImage(result.Images[0].Url, cancellationToken);
WriteLine("Image received!");
var fileName = "waifu" + result.Images[0].Extension;
using var fileStream = File.OpenWrite(fileName);
await stream.CopyToAsync(fileStream, cancellationToken);

WriteLine($"Image saved to {fileName}");
