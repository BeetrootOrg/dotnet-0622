using System;
using System.Threading;

namespace ConsoleApp;

class Renderer
{
    public Field Field { get; init; }
    private Timer _timer;

    public Renderer()
    {
        _timer = new Timer(Update, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
    }

    public void StartGame()
    {
        _timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(1));
    }

    public void Show()
    {
        // field
        Console.ForegroundColor = ConsoleColor.Red;
        for (var i = 0; i < Field.Size; ++i)
        {
            Console.SetCursorPosition(0, i);
            Console.Write('*');

            Console.SetCursorPosition(Field.Size - 1, i);
            Console.Write('*');

            Console.SetCursorPosition(i, 0);
            Console.Write('*');

            Console.SetCursorPosition(i, Field.Size - 1);
            Console.Write('*');
        }

        // snake
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var snake in Field.Snake.Body)
        {
            Console.SetCursorPosition(snake.X, snake.Y);
            Console.Write("X");
        }

        // food
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(Field.Food.Position.X, Field.Food.Position.Y);
        Console.Write("Y");
    }

    public void Update(object state)
    {
        Field.Snake.Move();
        Field.CheckSnakePosition();
        Console.Clear();
        Show();
        while(true) 
            Field.Snake.ReadMovement(Console.ReadKey(true).Key);
    }
}