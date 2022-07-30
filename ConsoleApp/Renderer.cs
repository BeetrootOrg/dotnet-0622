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
        _timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(0.5));
    }

    public void Show()
    {
        // field
        Console.ForegroundColor = ConsoleColor.Blue;
        for (var i = 0; i < Field.Size; ++i)
        {
            Console.SetCursorPosition(0, i);
            Console.Write('~');

            Console.SetCursorPosition(Field.Size - 1, i);
            Console.Write('~');

            Console.SetCursorPosition(i, 0);
            Console.Write('~');

            Console.SetCursorPosition(i, Field.Size - 1);
            Console.Write('~');
        }

        // snake
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var snake in Field.Snake.Body)
        {
            Console.SetCursorPosition(snake.X, snake.Y);
            Console.Write("*");
        }

        // food
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(Field.Food.Position.X, Field.Food.Position.Y);
        Console.Write("♥");
    }
    public void SnakeEat()
    {
        var snakeBody = Field.Snake.Body;
        var head = snakeBody[snakeBody.Count - 1];
        if (head.X == Field.Food.Position.X && head.Y == Field.Food.Position.Y)
        {
            snakeBody.Insert(0, new Point(snakeBody[0].X, snakeBody[0].Y));
            Field.Food = Food.Random(Field.Size);
        }
    }
    public void CheckIfFoodIsOnSnake()
    {
        var snakeBody = Field.Snake.Body;
        for (int i = 0; i < snakeBody.Count; i++)
        {
            if (snakeBody[i].X == Field.Food.Position.X && snakeBody[i].Y == Field.Food.Position.Y)
            {
                Field.Food = Food.Random(Field.Size);
            }
        }
    }
    private void Update(object state)
    {
        Field.Snake.Move(Field.Size);
        SnakeEat();
        CheckIfFoodIsOnSnake();
        Console.Clear();
        Show();
    }
}