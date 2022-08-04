using System;
using System.Net.Http;

using static System.Console;

using ConsoleApp;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Menu();

        using var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) =>
        {
            cancellationTokenSource.Cancel();
        };

        using HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://api.ipify.org"),
            Timeout = TimeSpan.FromSeconds(10)
        };

        IpClient ipClient = new IpClient(httpClient);

        IpResponseWrapper currentIpAddressWrapper = await ipClient.GetCurrentIp();
        string currentIpAddress = currentIpAddressWrapper.Ip;

        ProcessFinal(currentIpAddress);
    }
    

    private static void ProcessFinal(string currentIpAddress)
    {
        Clear();
        Write("Your IP Address is: ");
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine(currentIpAddress);
        ForegroundColor = ConsoleColor.Gray;
        WriteLine("Press any key to continue...");
        ReadKey();
        Clear();
    }

    static void Menu()
    {
        while (true)
        {
            Clear();
            WriteLine("Welcome to IP App!");
            WriteLine("\t1 - Get your IP Address!");
            WriteLine("\t0 - Exit!");
            var key = ReadKey();
            if (key.Key == ConsoleKey.D1)
            {
                Clear();
                break;
            }
            else if (key.Key == ConsoleKey.D0)
            {
                Clear();
                Environment.Exit(0);
            }

        }
    }
}