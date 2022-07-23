using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Snake
{
    class Field
    {
        public Snake Snake { get; init; }
        public Food Food { get; set; }
        public int Size { get; init; } = 15;


        public void CollisionCheck()
        {
            var head = Snake.Body.Last();

            //Wall Collision
            if (head.X == Size || head.Y == Size || head.X == 0|| head.Y == 0)
            {
                throw new Exception("YOU BROKE THE 4TH WALL! CONGRATULATIONS!");
            }
            //Food Collision
            if (head.X == Food.Position.X && head.Y == Food.Position.Y)
            {
                Snake.FoddEaten();
                Food = Food.Random(Size);
            }

            //Snake Body Collision
            foreach (var element in Snake.Body)
            {
                if(Food.Position.X == element.X && Food.Position.Y == element.Y)
                {
                    while(Food.Position.X == element.X && Food.Position.Y == element.Y)
                    {
                        Food = Food.Random(Size);
                    }
                }
                if (element.X == head.X && element.Y == head.Y)
                {
                    if (element == head) continue;
                    throw new Exception("YOU EAT YOURSELF!");
                }

            }
        }
    }
}
