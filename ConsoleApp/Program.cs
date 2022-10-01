using System;

using static System.Console;

namespace ConsoleApp;

delegate void KeyPressEventHandler(object sender, ConsoleKey e);

internal class Program
{
    static event KeyPressEventHandler KeyPress;

    private static void Main(string[] args)
    {
        const int Size = 15;
        var snake = new Snake
        {
            IndexBorder = Size - 1
        };
        var food = Food.Random(Size);
        Field field = new Field
        {
            Food = food,
            Size = Size,
            Snake = snake
        };
        //KeyPress += new KeyPressEventHandler(field.Snake.ReadDirection);

        var renderer = new Renderer
        {
            Field = field
        };
        System.Console.Clear();
        renderer.Show();
        renderer.StartGame();
        Thread.Sleep(Timeout.Infinite);
        //PressKeyConsole(field.Snake, ReadKey().Key);
    }
}