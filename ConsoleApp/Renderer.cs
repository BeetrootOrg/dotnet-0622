using System;

namespace ConsoleApp;

class Renderer
{
    private const char ClearSymbol = ' ';
    private const char BorderSymbol = '\x2588';
    private const char SnakeSymbol = '\x2588';
    private const char FoodSymbol = '\x00F6';

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
            Console.Write(BorderSymbol);
        }
    }

    public void Show()
    {
        // remove old
        Console.ForegroundColor = ConsoleColor.Black;
        if (_lastSnakePart != null)
        {
            Console.SetCursorPosition(_lastSnakePart.X, _lastSnakePart.Y);
            Console.Write(ClearSymbol);
        }

        if (_lastFood != null && !GameField.Food.SamePosition(_lastFood))
        {
            Console.Write(ClearSymbol);
        }

        // snake
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.SetCursorPosition(GameField.Snake.Head.X, GameField.Snake.Head.Y);
        Console.Write(SnakeSymbol);

        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var snakeBody in GameField.Snake.Body)
        {
            Console.SetCursorPosition(snakeBody.X, snakeBody.Y);
            Console.Write(SnakeSymbol);
            _lastSnakePart = new Point(snakeBody.X, snakeBody.Y);
        }

        // food
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(GameField.Food.X, GameField.Food.Y);
        Console.Write(FoodSymbol);
        _lastFood = new Point(GameField.Food.X, GameField.Food.Y);

        // set cursor position outside the world
        Console.SetCursorPosition(GameField.FieldBorder.Size + 1, GameField.FieldBorder.Size + 1);
    }
}