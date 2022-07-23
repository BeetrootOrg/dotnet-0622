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

    public void StartGame(double speed)
    {
        _timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(speed));
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
        GenerateFood();
    }

    private void Update(object state)
    {
        CheckIfHeadOnBorder();
        CheckIfHeadOnBody();
        var snake = Field.Snake;        
        if (snake.SnakeHead.X == Field.Food.Position.X && snake.SnakeHead.Y == Field.Food.Position.Y)
        {
            snake.Body.Insert(0, new Point(snake.SnakeTail.X, snake.SnakeTail.Y));
            Field.Food = Food.Random(Field.Size);
        }
        snake.Move();        
        Console.Clear();
        Show();
    }
    private void CheckIfHeadOnBorder()
    {
        var snakeHead = Field.Snake.SnakeHead;
        if (snakeHead.X == 0 || snakeHead.Y == 0 || snakeHead.X == Field.Size - 1 || snakeHead.Y == Field.Size - 1)
        {
            Environment.Exit(0);
        }
    }
    private void CheckIfHeadOnBody()
    {
        for (int i = 0; i < Field.Snake.Body.Count - 1; i++)
        {
            if (Field.Snake.SnakeHead.X == Field.Snake.Body[i].X && Field.Snake.SnakeHead.Y == Field.Snake.Body[i].Y)
            {
                Environment.Exit(0);
            }
        }
    }
    private void GenerateFood()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(Field.Food.Position.X, Field.Food.Position.Y);
        Console.Write("Y");
    }
}