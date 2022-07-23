using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Snake
{
    record struct Food(Point Position)
    {
        public static Food Random(int size)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            return new Food(new Point
            {
                X = random.Next(1, size - 1),
                Y = random.Next(1, size - 1)
            });
        }
    }
}
