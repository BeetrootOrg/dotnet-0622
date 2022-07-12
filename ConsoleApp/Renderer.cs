using System;
using System.Threading;

namespace ConsoleApp;

class Renderer
{
    public Field Field {get;init;}
    private Timer _timer;

    public Renderer()
    {
        _timer = new Timer(Update, null, Timeout.InfiniteTimeSpan, TimeSpan.Zero);
    }

    public void StartGame()
    {
        _timer.Change(TimeSpan.Zero, TimeSpan.FromMilliseconds(200));
    }

    public void Show()
    {
        // walls
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        foreach(var wall in Field.Walls.Walls)
        {
            Console.SetCursorPosition(wall.X, wall.Y);
            Console.Write('#');
        }

        // food
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(Field.Food.Point.X, Field.Food.Point.Y);
        Console.Write('@');

        // snake
        Console.ForegroundColor = ConsoleColor.Green;
        for(int i = 0; i<Field.Snake._body.Count-1; i++)
        {
            Console.SetCursorPosition(Field.Snake._body[i].X, Field.Snake._body[i].Y);
            Console.Write('O');
        }
        if (Field.Snake._direcrion == Direction.Right)
        {
            Console.SetCursorPosition(Field.Snake._body[Field.Snake._body.Count-1].X, Field.Snake._body[Field.Snake._body.Count-1].Y);
            Console.Write('>');
        }
        if (Field.Snake._direcrion == Direction.Left)
        {
            Console.SetCursorPosition(Field.Snake._body[Field.Snake._body.Count-1].X, Field.Snake._body[Field.Snake._body.Count-1].Y);
            Console.Write('<');
        }
        if (Field.Snake._direcrion == Direction.Down)
        {
            Console.SetCursorPosition(Field.Snake._body[Field.Snake._body.Count-1].X, Field.Snake._body[Field.Snake._body.Count-1].Y);
            Console.Write('v');
        }
        if (Field.Snake._direcrion == Direction.Up)
        {
            Console.SetCursorPosition(Field.Snake._body[Field.Snake._body.Count-1].X, Field.Snake._body[Field.Snake._body.Count-1].Y);
            Console.Write('^');
        }
        Console.CursorVisible = false;
    }
    private void Update(object state)
    {
        // wall crash
        foreach (var wall in Field.Walls.Walls)
        {
            if (Field.Snake._body[Field.Snake._body.Count-1].X == wall.X &&
                Field.Snake._body[Field.Snake._body.Count-1].Y == wall.Y)
            Environment.Exit(0);  
        }

        // eat himself
        for(int i = 0; i<Field.Snake._body.Count-2; i++)
        {
            if (Field.Snake._body[Field.Snake._body.Count-1].X == Field.Snake._body[i].X &&
                Field.Snake._body[Field.Snake._body.Count-1].Y == Field.Snake._body[i].Y)
            Environment.Exit(0);  
        }
        
        // eat
        if(Field.Snake._body[Field.Snake._body.Count-1].X == Field.Food.Point.X &&
           Field.Snake._body[Field.Snake._body.Count-1].Y == Field.Food.Point.Y)
        {
            Field.Snake._body.Add(Field.Food.Point);

            var random = new Random((int)DateTime.Now.Ticks);
            List<Point> posibleFoodSpawnPoints = new List<Point>();
            for (int x = 1; x<Field.Size; x++)
            {
                for (int y = 1; y<Field.Size; y++)
                {
                    if (!Field.Snake._body.Contains(new Point{ X = x, Y = y}))
                        posibleFoodSpawnPoints.Add(new Point{ X = x, Y = y});
                }   
            }    
            Field.Food = new Food(posibleFoodSpawnPoints[random.Next(0,posibleFoodSpawnPoints.Count+1)]);
        }
        
        Field.Snake.Move();
        Console.Clear();
        Show();
    }
}