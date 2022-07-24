using System;

namespace ConsoleApp;

class Renderer
{
    public GameField GameField { get; init; }

    public Renderer()
    {
    }

    public void Show()
    {
        Console.Clear();

        // field
        Console.ForegroundColor = ConsoleColor.Red;
        foreach (var (x, y) in GameField.FieldBorder)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
        }

        // snake
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var snakeBody in GameField.Snake)
        {
            Console.SetCursorPosition(snakeBody.X, snakeBody.Y);
            Console.Write("X");
        }

        // food
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(GameField.Food.X, GameField.Food.Y);
        Console.Write("Y");
    }
}