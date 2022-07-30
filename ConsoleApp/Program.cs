using System;
using System.IO;
using System.Net.Http;

using ConsoleApp;

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://foodish-api.herokuapp.com"),
    Timeout = TimeSpan.FromSeconds(5)
};

var foodClient = new FoodClient(httpClient);

var result = await foodClient.GetRandomFood();
using var stream = await foodClient.GetImage(result.Image);

using var fileStream = File.OpenWrite("food.jpg");
await stream.CopyToAsync(fileStream);