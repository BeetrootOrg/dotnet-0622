using System;
using System.Diagnostics;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApp;

internal class Program
{
    private static async Task Main()
    {
        var stopwatch = new Stopwatch();

        stopwatch.Start();
        var panTask = HeatUpAPan();
        var heatWaterTask = HeatUpWater();
        await PourAGlassOfWater();
        await DrinkWater();

        await panTask;

        var twoEggsTask = FryTwoEggs();
        var baconTask = FrySliceOfBacon();

        await heatWaterTask;
        await MakeACupOfCoffee();

        await Task.WhenAll(twoEggsTask, baconTask);

        await ServeDish();
        await EatBreakfast();
        stopwatch.Stop();

        WriteLine($"Breakfast last for {stopwatch.Elapsed}");
    }

    private static async Task HeatUpAPan()
    {
        await Task.Delay(TimeSpan.FromSeconds(3));
        WriteLine("Pan ready!");
    }

    private static async Task FryTwoEggs()
    {
        await Task.Delay(TimeSpan.FromSeconds(5));
        WriteLine("Eggs ready!");
    }

    private static async Task HeatUpWater()
    {
        await Task.Delay(TimeSpan.FromSeconds(4));
        WriteLine("Water ready!");
    }

    private static async Task MakeACupOfCoffee()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        WriteLine("Coffee ready!");
    }

    private static async Task FrySliceOfBacon()
    {
        await Task.Delay(TimeSpan.FromSeconds(4));
        WriteLine("Bacon ready!");
    }

    private static async Task ServeDish()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        WriteLine("Dish ready!");
    }

    private static async Task PourAGlassOfWater()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        WriteLine("Glass of water ready!");
    }

    private static async Task DrinkWater()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        WriteLine("Water drunk!");
    }

    private static async Task EatBreakfast()
    {
        await Task.Delay(TimeSpan.FromSeconds(8));
        WriteLine("Breakfast done!");
    }
}