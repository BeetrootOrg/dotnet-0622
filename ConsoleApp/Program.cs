using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp;

using static System.Console;

using var httpClient = new HttpClient
{
    BaseAddress = new Uri ("https://uselessfacts.jsph.pl/"),
    Timeout = TimeSpan.FromSeconds(5)
};

var factClient = new FactClient(httpClient);

var result = await factClient.GetRandomFact();
WriteLine(result.Text);