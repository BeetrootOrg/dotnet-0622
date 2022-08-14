using System;
using System.Net.Http;
using System.IO;
using ConsoleApp;

using var httpclient = new HttpClient
{
    BaseAddress = new Uri("https://randomfox.ca/floof/"),
    Timeout = TimeSpan.FromSeconds(5)
};

var foxClient = new FoxClient(httpclient);

var result = await foxClient.GetRandomFox();

await foxClient.GetImage(result.Image);
