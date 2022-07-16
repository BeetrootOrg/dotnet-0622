using System;

namespace ConsoleApp
{
    class Program
    {
        public const int MapAreaWidth = 50;
        public const int MapAreaHeight = 20;
        private const ConsoleColor _backgroundcolor = ConsoleColor.DarkCyan;
        private const ConsoleColor _headcolor = ConsoleColor.Red;
        private const ConsoleColor _bodycolor = ConsoleColor.DarkYellow;
        private const ConsoleColor _foodcolor = ConsoleColor.DarkGreen;
        

        private static Random _random = new Random();
        public static void Main()
        {
            int counter = 0;
            Console.SetWindowSize(MapAreaWidth, MapAreaHeight);
            Console.SetBufferSize(MapAreaWidth, MapAreaHeight);
            Console.CursorVisible = false;
           
           DrawBorder();

            Snake snake = new Snake(10, 5, _headcolor,_bodycolor);
            bool ifEat = false;
            Direction currentDirection = Direction.right;
            Pixel food = FoodGenerator(snake);

            food.Draw();
            while (true)
            {
                if (snake.Head.X==food.X&&snake.Head.Y==food.Y)
                {
                    ifEat=true;
                    food = FoodGenerator(snake);
                    food.Draw();
                    counter++;

                }
                snake.Move(currentDirection,ifEat);
                ifEat = false;
                if (Console.KeyAvailable == true)
                {
                   currentDirection = ChangeDirection(currentDirection);
                }
                
                
                Thread.Sleep(100);

                if (snake.Head.X == MapAreaWidth-2
                    || snake.Head.X == 1
                    || snake.Head.Y == MapAreaHeight - 2
                    || snake.Head.Y == 1
                    || snake.Body.Any(val=> val.X ==snake.Head.X && val.Y == snake.Head.Y)
                    )
                {
                    
                    snake.Clear();

                    Console.SetCursorPosition(10, 10);

                    Console.WriteLine($"Score is {counter} Game Over");

                    break;
                }

                
                
               
            }

        }

        static Pixel FoodGenerator(Snake snake)
        {
            Pixel food;

            do
            {
                food = new Pixel(_random.Next(3, MapAreaWidth-3), _random.Next(3, MapAreaHeight - 3), _foodcolor);
            } 
            while (snake.Head.X==food.X&&snake.Head.Y==food.Y || snake.Body.Any(b=>b.X==food.X&&b.Y==food.Y));
            return food;

            
        }

        public static Direction ChangeDirection(Direction direction)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.LeftArrow:
                    if (direction == Direction.right)
                    {
                        direction = Direction.right;
                        return direction;
                    }
                    else
                        direction = Direction.left;
                    return direction;
                    break;
                case ConsoleKey.RightArrow:
                    if (direction == Direction.left)
                    {
                        direction = Direction.left;
                        return direction;
                    }
                    else
                        direction = Direction.right;
                    return direction;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction == Direction.up)
                    {
                        direction = Direction.up;
                        return direction;
                    }
                    else
                        direction = Direction.down;
                    return direction;
                    break;
                case ConsoleKey.UpArrow:
                    if (direction == Direction.down)
                    {
                        direction = Direction.down;
                        return direction;
                    }
                    else
                        direction = Direction.up;
                    return direction;
                    break;
                default:
                    return direction;
                    break;
            }

        }

        public static void DrawBorder()
        {
            for (int i = 0; i < MapAreaWidth; i++)
            {
                new Pixel(i, 0, _backgroundcolor).Draw();
                new Pixel(i, MapAreaHeight - 1, _backgroundcolor).Draw();
            }
            for (int i = 0; i < MapAreaHeight; i++)
            {
                new Pixel(0, i, _backgroundcolor).Draw();
                new Pixel(MapAreaWidth - 1, i , _backgroundcolor).Draw();
            }
        }
    }
}
