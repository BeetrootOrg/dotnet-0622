using System;
using System.Linq;
using System.IO;
using System.Net.Http;

using static System.Console;

using ConsoleApp;
using System.Threading;

using var cancellationTokenSource = new CancellationTokenSource();
var cancellationToken = cancellationTokenSource.Token;

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.open-meteo.com/"),
    Timeout = TimeSpan.FromSeconds(5)
};

WriteLine("Enter latitude: ");
var lat = ReadLine();
WriteLine("Enter longitude: ");
var lon = ReadLine();
var weaterClient = new WeaterClient(httpClient, lat, lon);

WriteLine("Awaiting for weather...");
var result = await weaterClient.GetWeather(cancellationToken);
WriteLine($"Current temperature is: {result.Temperature}");
WriteLine($"Current windspeed is: {result.WindSpeed}");
WriteLine($"Current wind direction is: {result.WindDirection}");











