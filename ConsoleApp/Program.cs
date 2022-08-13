
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApp;

internal class Program
{
    private static async Task Main()
    {
        var stopwatch = new Stopwatch();

        var asyncTask = YieldExample();
        var asyncTask2 = TaskRunExample();
        
        stopwatch.Start();
        var panTask = HeatUpAPan();
        var heatWaterTask = HeatUpWater();
        await PourAGlassOfWater();
        await DrinkWater();
        await panTask;

        var twoEggsTask = FryTwoEggs();
        var beakonTask = FrySliceOfBeacon();

        await heatWaterTask;
        await MakeACupOfCoffee();

        await Task.WhenAll(twoEggsTask, beakonTask);

        await ServeDish();
        await EatBreakfast();
        stopwatch.Stop();

        WriteLine($"Breakfast last for {stopwatch.Elapsed}");
    }
    private static async Task HeatUpAPan()
    {
        await Task.Delay(TimeSpan.FromSeconds(3));
        WriteLine("Pen ready!");
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
    private static async Task FrySliceOfBeacon()
    {
        await Task.Delay(TimeSpan.FromSeconds(4));
        WriteLine("Beacon ready!");
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
    private static async Task YieldExample()
    {
        await Task.Yield();
        //long sync code
        Thread.Sleep(TimeSpan.FromSeconds(3));
        //then sync code
        await Task.Delay(TimeSpan.FromSeconds(3));
        WriteLine("End of async");
    }
    private static async Task TaskRunExample()
    {
        //long sync code
        await Task.Run(() => Thread.Sleep(TimeSpan.FromSeconds(3)));
        //then sync code
        await Task.Delay(TimeSpan.FromSeconds(3));
        WriteLine("End of async");
    }
}