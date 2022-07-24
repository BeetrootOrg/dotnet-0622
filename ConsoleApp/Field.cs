using System.Linq;
using System;
namespace ConsoleApp;

class Field
{
    public Snake Snake { get; init; }
    public Food Food { get; set; }
    public int Size { get; init; } = 15;

    public void CheckSnakePosition()
    {
        var head = Snake.Body.Last();

        foreach (var point in Snake.Body)
        {
            if (head.X == Size || head.Y == Size || head.X == 0 || head.Y == 0)
                throw new Exception("Game Over");
            if (point.X == head.X && point.Y == head.Y)
            {
                if (point == head) continue;
                throw new Exception("Game Over");
            }
            if (Food.Position.X == point.X && Food.Position.Y == point.Y)
            {
                while (Food.Position.X == point.X && Food.Position.Y == point.Y)
                    Food = Food.Random(Size);
            }
            if (head.X == Food.Position.X && head.Y == Food.Position.Y)
            {
                Snake.EatFood();
                Food = Food.Random(Size);
            }
        }
    }
}


