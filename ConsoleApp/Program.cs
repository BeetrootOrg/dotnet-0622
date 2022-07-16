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
        public static void Main()
        {
            Console.SetWindowSize(MapAreaWidth, MapAreaHeight);
            Console.SetBufferSize(MapAreaWidth, MapAreaHeight);
            Console.CursorVisible = false;
           
           DrawBorder();

            Snake snake = new Snake(10, 5, _headcolor,_bodycolor);
            Direction currentDirection = Direction.right;
            while (true)
            {
                
               
                snake.Move(currentDirection);
                if (Console.KeyAvailable == true)
                {
                   currentDirection = ChangeDirection(currentDirection);
                }
                
                Thread.Sleep(100);
            }


            
            

            Console.ReadKey();
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
