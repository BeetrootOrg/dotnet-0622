using System.Threading;
using System;

using ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        const int Size = 15;
        System.Console.WriteLine("Choose difficulty:");
        System.Console.WriteLine("\t1. Easy");
        System.Console.WriteLine("\t2. Medium");
        System.Console.WriteLine("\t3. Hard");
        System.Console.WriteLine("\t3. Extreme");
        double timerSpeed = 0;

        var difficultyKey = Console.ReadKey();
        switch (difficultyKey.Key)
        {
            case ConsoleKey.D1:
                timerSpeed = 1;
                break;
            case ConsoleKey.D2:
                timerSpeed = 0.5;
                break;
            case ConsoleKey.D3:
                timerSpeed = 0.2;
                break;
            case ConsoleKey.D4:
                timerSpeed = 0.05;
                break;
            default:
                timerSpeed = 1;
                break;
        }


        var snake = new Snake();
        var food = Food.Random(Size);
        var field = new Field
        {
            Food = food,
            Size = Size,
            Snake = snake
        };

        var renderer = new Renderer
        {
            Field = field
        };

        Console.Clear();
        renderer.Show();
        renderer.StartGame(timerSpeed);

        while (true)
        {
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    renderer.Field.Snake.Direction = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    renderer.Field.Snake.Direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    renderer.Field.Snake.Direction = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    renderer.Field.Snake.Direction = Direction.Left;
                    break;
                case ConsoleKey.Backspace:
                    Environment.Exit(0);
                    break;
                default:
                    continue;
            }
        }


        //Thread.Sleep(Timeout.Infinite);
    }
}