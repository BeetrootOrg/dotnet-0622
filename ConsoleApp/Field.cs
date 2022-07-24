namespace ConsoleApp;
using System;
using System.Linq;
class Field
{
    public Snake Snake { get; init; }
    public Food Food { get; set; }
    public int Size { get; init; } = 15;


        public void HeadTracker()
    {

        int i = 0;
        int snakeLenght = Snake.Body.Count();
        var head = Snake.Body.Last();

        foreach (var point in Snake.Body)
        {   
            if (++i != snakeLenght && point.X == head.X && point.Y == head.Y)
            {
                throw new ("Game Over!");
            }

            if(head.X == Size || head.Y == Size || head.X == 0 || head.Y == 0 )
                throw new ("Game Over!");

            if (head.X == Food.Position.X && head.Y == Food.Position.Y)
                {
                    Snake.IsFoodEated = true;
                    Food = Food.Random(Size);
                }
        }
    }
}