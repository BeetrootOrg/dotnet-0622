using System;
using System.Threading;

using ConsoleApp;

internal partial class Program
{
    private static void Main(string[] args)
    {
        const int Size = 15;

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

        System.Console.Clear();
        renderer.Show();
        renderer.StartGame();

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
                case ConsoleKey.LeftArrow:
                    renderer.Field.Snake.Direction = Direction.Left;
                    break;
                case ConsoleKey.DownArrow:
                    renderer.Field.Snake.Direction = Direction.Down;
                    break;
                default:
                    throw new Exception("No such option");
            }
        }
    }
}