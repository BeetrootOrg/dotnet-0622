using System;

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
        //field
        Console.ForegroundColor = ConsoleColor.Red;
        for (var a = 0; a < Field.Size; ++a)
        {
            Console.SetCursorPosition(0, a);
            Console.Write('*');
            Console.SetCursorPosition(Field.Size - 1, a);
            Console.Write('*');
            Console.SetCursorPosition(a, 0);
            Console.Write('*');
            Console.SetCursorPosition(a, Field.Size - 1);
            Console.Write('*');
        }
        //snake
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var body in Field.Snake.Body)
        {
            Console.SetCursorPosition(body.X, body.Y);
            Console.Write('X');
        }

        //food
        Console.SetCursorPosition(Field.Food.Position.X, Field.Food.Position.Y);
        Console.Write('+');

    }

    private void Update(object state)
    {
        Field.Snake.Move(new Point() { X = 1, Y = 0 }, Field.Size);
        Console.Clear();
        Show();
    }
}