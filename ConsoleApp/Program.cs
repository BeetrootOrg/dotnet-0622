using System;

using static System.Console;

namespace ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        const int Size = 15;
        var snake = new Snake();
        var food = Food.Random(Size);
        Field field = new Field
        {
            Food = food,
            Size = Size,
            Snake = snake
        };

        var renderer = new Renderer
        {
            Field = field
        };
        System.Console.Clear();
        renderer.Show();
        renderer.StartGame();
        Thread.Sleep(Timeout.Infinite);
    }
}