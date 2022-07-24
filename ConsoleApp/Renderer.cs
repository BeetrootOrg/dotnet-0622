using System;

namespace ConsoleApp;

class Renderer
{
    public GameField GameField { get; init; }

    private Point _lastSnakePart;
    private Point _lastFood;

    public Renderer()
    {
    }

    public void Init()
    {
        Console.Clear();
        Console.CursorVisible = false;

        // field
        Console.ForegroundColor = ConsoleColor.Red;
        foreach (var (x, y) in GameField.FieldBorder)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
        }
    }

    public void Show()
    {
        // remove old
        Console.ForegroundColor = ConsoleColor.Black;
        if (_lastSnakePart != null)
        {
            Console.SetCursorPosition(_lastSnakePart.X, _lastSnakePart.Y);
            Console.Write(" ");
        }

        if (_lastFood != null && !GameField.Food.SamePosition(_lastFood))
        {
            Console.Write(" ");
        }

        // snake
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var snakeBody in GameField.Snake)
        {
            Console.SetCursorPosition(snakeBody.X, snakeBody.Y);
            Console.Write("X");
            _lastSnakePart = new Point(snakeBody.X, snakeBody.Y);
        }

        // food
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(GameField.Food.X, GameField.Food.Y);
        Console.Write("Y");
        _lastFood = new Point(GameField.Food.X, GameField.Food.Y);
    }
}