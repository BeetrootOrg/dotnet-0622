using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Snake
    {
        private readonly ConsoleColor _headcolor;
        private readonly ConsoleColor _bodycolor;

        public Snake (int initx, int inity, ConsoleColor Headcolor, ConsoleColor Bodycolor, int bodyinitsize = 3 )        {
            _headcolor = Headcolor;
            _bodycolor = Bodycolor;

            Head = new Pixel(initx, inity, _headcolor);

            Body = new Queue<Pixel>();

            for (int i = bodyinitsize; i >=0 ; i--)
            {
                Body.Enqueue(new Pixel(Head.X - i - 1, inity, _bodycolor));
            }

            Draw();
        }

        public void Move(Direction dir)
        {
            Clear();
            Body.Enqueue(new Pixel(Head.X, Head.Y, _bodycolor));
            Body.Dequeue();

            Direction direction = dir;

            switch (direction)
            {
                case Direction.up:
                    Head = (new Pixel(Head.X, Head.Y - 1, _headcolor));
                    break;
                case Direction.down:
                    Head = (new Pixel(Head.X, Head.Y + 1, _headcolor));
                    break;
                case Direction.left:
                    Head = (new Pixel(Head.X - 1, Head.Y, _headcolor));
                    break;
                case Direction.right:
                    Head = (new Pixel(Head.X + 1, Head.Y, _headcolor));
                    break;
                 
                default:
                    break;
            }
            Draw();
        }

        public void Draw()
        {
            Head.Draw();

            foreach (Pixel pixel in Body)
            {
                pixel.Draw();
            }
        }

        public void Clear()
        {
            Head.Clear();

            foreach (Pixel pixel in Body)
            {
                pixel.Clear();
            }
        }


        public Pixel Head { get; private set; }

        public Queue<Pixel> Body { get; private set; }
    }
}
