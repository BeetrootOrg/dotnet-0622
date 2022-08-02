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

var weatherClient = new WeatherClient(httpClient);
WriteLine("Enter latitude: ");
var lat = ReadLine();
WriteLine("Enter longitude: ");
var lon = ReadLine();

WriteLine("Awaiting for weather...");
var result = await weatherClient.GetWeather(lat, lon, cancellationToken);
WriteLine($"Current temperature is: {result.Temperature}");
WriteLine($"Current windspeed is: {result.WindSpeed}");
WriteLine($"Current wind direction is: {result.WindDirection}");