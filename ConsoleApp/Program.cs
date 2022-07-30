using System;
using System.Diagnostics;
using System.Threading;

using static System.Console;

namespace ConsoleApp;

internal class Program
{
    private static void Main()
    {
        var stopwatch = new Stopwatch();

        stopwatch.Start();
        HeatUpAPan();
        FryTwoEggs();
        FrySliceOfBacon();
        HeatUpWater();
        MakeACupOfCoffee();
        PourAGlassOfWater();
        DrinkWater();
        ServeDish();
        EatBreakfast();
        stopwatch.Stop();

        WriteLine($"Breakfast last for {stopwatch.Elapsed}");
    }

    private static void HeatUpAPan()
    {
        Thread.Sleep(TimeSpan.FromSeconds(3));
        WriteLine("Pan ready!");
    }

    private static void FryTwoEggs()
    {
        Thread.Sleep(TimeSpan.FromSeconds(5));
        WriteLine("Eggs ready!");
    }

    private static void HeatUpWater()
    {
        Thread.Sleep(TimeSpan.FromSeconds(4));
        WriteLine("Water ready!");
    }

    private static void MakeACupOfCoffee()
    {
        Thread.Sleep(TimeSpan.FromSeconds(2));
        WriteLine("Coffee ready!");
    }

    private static void FrySliceOfBacon()
    {
        Thread.Sleep(TimeSpan.FromSeconds(4));
        WriteLine("Bacon ready!");
    }

    private static void ServeDish()
    {
        Thread.Sleep(TimeSpan.FromSeconds(1));
        WriteLine("Dish ready!");
    }

    private static void PourAGlassOfWater()
    {
        Thread.Sleep(TimeSpan.FromSeconds(1));
        WriteLine("Glass of water ready!");
    }

    private static void DrinkWater()
    {
        Thread.Sleep(TimeSpan.FromSeconds(1));
        WriteLine("Water drunk!");
    }

    private static void EatBreakfast()
    {
        Thread.Sleep(TimeSpan.FromSeconds(8));
        WriteLine("Breakfast done!");
    }
}