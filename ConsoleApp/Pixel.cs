
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public readonly struct Pixel
    {
        public Pixel(int x, int y, ConsoleColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }
        
        public int X { get; }

        public int Y { get; }

        public ConsoleColor Color { get; }

        public Pixel(int y) : this()
        {
            Y = y;
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X,Y);
            Console.Write('█');
           
        }
        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }
    }
}
