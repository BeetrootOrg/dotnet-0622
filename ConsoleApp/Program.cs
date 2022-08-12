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
    BaseAddress = new Uri("https://uselessfacts.jsph.pl"),
    Timeout = TimeSpan.FromSeconds(5)
};

var randomFactClient = new RandomFactClient(httpClient);


System.Console.WriteLine("Please, select language:");
System.Console.WriteLine("English - '1'");
System.Console.WriteLine("German - '2'");
string language = "?language=";
int lang = 0;
Int32.TryParse(Console.ReadLine(), out lang);
switch (lang)
{
    case 1:
    language += "en";
        break;
    case 2: 
    language += "de";
        break;
    default:
    language += "en";
        break;
}

System.Console.WriteLine("Please, select random or today fact:");
System.Console.WriteLine("Random - '0'");
System.Console.WriteLine("Today - '1'");
string type = ".json";
int tempType = 0;
Int32.TryParse(Console.ReadLine(), out tempType);
switch (tempType)
{
    case 0:
    type = type.Insert(0, "/random");
        break;
    case 1: 
    type = type.Insert(0, "/today");
        break;
    default:
    type = type.Insert(0, "/random");
        break;
}

var message = type == "/random.json"? "Random fact:" : "Today fact:";
System.Console.WriteLine(message);
var result = await randomFactClient.GetRandomFact(type + language, cancellationToken);
System.Console.WriteLine(result.Fact);