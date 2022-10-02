using System;

namespace ConsoleApp;

class Renderer
{
    public Field Field { get; set; }

    public Snake Snake { get; set; }

    public Food Food { get; set; }

    private Timer _timer;

    public Renderer(int size)
    {
        Field = new Field
        {
            Size = size
        };
        Snake = new Snake(3, size - 1);
        Food = Food.Random(size);

        _timer = new Timer(Update, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
    }

    public void StartGame()
    {
        _timer.Change(TimeSpan.Zero, TimeSpan.FromMilliseconds(750));
    }

    public void Show()
    {
        //field
        Console.ForegroundColor = ConsoleColor.Red;
        for (var a = 0; a < Field.Size; ++a)
        {
            Console.SetCursorPosition(0, a);
            Console.Write('#');
            Console.SetCursorPosition(Field.Size - 1, a);
            Console.Write('#');
            Console.SetCursorPosition(a, 0);
            Console.Write('#');
            Console.SetCursorPosition(a, Field.Size - 1);
            Console.Write('#');
        }
        //snake
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var body in Snake.Body)
        {
            Console.SetCursorPosition(body.X, body.Y);
            Console.Write('X');
        }

        //food
        Console.SetCursorPosition(Food.Position.X, Food.Position.Y);
        Console.Write('+');
        Console.SetCursorPosition(0, Field.Size);

    }

    private void Update(object state)
    {
        if (Snake.Move(Food.Position, Console.ReadKey().Key))
        {
            Food = Food.Random(Field.Size);
            while (Snake.Body.Contains(Food.Position))
            {
                Food = Food.Random(Field.Size);
            }
        }
        Console.Clear();
        Show();
    }

}