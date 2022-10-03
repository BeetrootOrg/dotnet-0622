using System;

namespace ConsoleApp;

class Renderer
{
    public int Size { get; set; }

    public Snake Snake { get; set; }

    public Food Food { get; set; }

    private Timer _timer;

    public Renderer(int size)
    {
        Size = size;
        Snake = new Snake(3, size - 1);
        NewFood();

        _timer = new Timer(Update, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
    }

    public void StartGame()
    {
        System.Console.Clear();
        Show();
        _timer.Change(TimeSpan.Zero, TimeSpan.FromMilliseconds(750));
    }

    public void Show()
    {
        //field
        Console.ForegroundColor = ConsoleColor.Red;
        for (var a = 0; a < Size; ++a)
        {
            Console.SetCursorPosition(0, a);
            Console.Write('#');
            Console.SetCursorPosition(Size - 1, a);
            Console.Write('#');
            Console.SetCursorPosition(a, 0);
            Console.Write('#');
            Console.SetCursorPosition(a, Size - 1);
            Console.Write('#');
        }
        //snake
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var body in Snake.Body)
        {
            Console.SetCursorPosition(body.X, body.Y);
            Console.Write('O');
        }
        Console.SetCursorPosition(Console.GetCursorPosition().Left - 1, Console.GetCursorPosition().Top);
        Console.Write('B');

        //food
        Console.SetCursorPosition(Food.Position.X, Food.Position.Y);
        Console.Write('+');
        Console.SetCursorPosition(0, Size);

    }
    private void NewFood()
    {
        Food = Food.Random(Size);
        while (Snake.Body.Contains(Food.Position))
        {
            Food = Food.Random(Size);
        }
    }

    private void Update(object state)
    {
        if (Snake.Move(Food.Position, Console.ReadKey().Key))
        {
            NewFood();
        }
        Console.Clear();
        Show();
    }

}