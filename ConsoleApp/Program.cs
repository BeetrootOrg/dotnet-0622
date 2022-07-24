namespace Snake;
class Program
{
    static void Main(string[] args)
    {
        Walls walls = new Walls(40, 15);
        walls.Draw();


        Point p = new Point(4, 5, '*');
        Snake snake = new Snake(p, 4, Direction.RIGHT);
        snake.Draw();

        FoodCreator foodCreator = new FoodCreator(40, 15, '$');
        Point food = foodCreator.CreateFood();
        food.Draw();


        while (true)
        {
            if (walls.IsHit(snake) || snake.IsHitTail())
            {
                break;
            }
            if (snake.Eat(food))
            {
                food = foodCreator.CreateFood();
                food.Draw();
                snake.Draw();
            }
            else
            {
                snake.Move();
            }
            Thread.Sleep(100);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.HandleKey(key.Key);
            }
        }
        WriteGameOver();
        Console.ReadLine();
    }

    static void WriteGameOver()
    {
        int xText = 25;
        int yText = 8;
        Console.SetCursorPosition(xText, yText);
        Console.WriteLine("GG");
    }

   
}