using System.Collections.Generic;

namespace ConsoleApp.Snake
{
    enum Direction
    {
        Up,
        Right,
        Down,
        Left
    }

    class Snake
    {
        private List<Point> _body;
        public IEnumerable<Point> Body => _body;
        public Direction Direction { get; set; }

        public Snake(int size = 3)
        {
            _body = new List<Point>(size);
            _body.Add(new Point
            {
                X = 1,
                Y = 1
            });
            for (var i = 0; i < size - 1; ++i)
            {
                _body.Add(new Point
                {
                    X = i + 1,
                    Y = 1
                });
            }
            Direction = Direction.Right;
        }

        public void FoddEaten()
        {
            _body.Insert(0, new Point { X = 0, Y = 0 });
        }
        public void Move()
        {
            for (var i = 0; i < _body.Count - 1; ++i)
            {
                var prevPart = _body[i];
                var nextPart = _body[i + 1];

                prevPart.X = nextPart.X;
                prevPart.Y = nextPart.Y;

            }

            var head = _body.Last();
            switch (this.Direction)
            {
                case Direction.Up:
                    head.Y--;
                    break;

                case Direction.Right:

                    head.X++;
                    break;

                case Direction.Down:
                    head.Y++;
                    break;

                case Direction.Left:
                    head.X--;
                    break;

                default: break;

            }


        }

        public void DiractionChange(ConsoleKey consoleKey)
        {
            switch (consoleKey)
            {
                case ConsoleKey.UpArrow:
                    {
                        if (this.Direction == Direction.Up || this.Direction == Direction.Down) break;
                        this.Direction = Direction.Up;
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        if (this.Direction == Direction.Up || this.Direction == Direction.Down) break;
                        this.Direction = Direction.Down;
                        break;
                    }
                case ConsoleKey.RightArrow:
                    {
                        if (this.Direction == Direction.Right || this.Direction == Direction.Left) break;
                        this.Direction = Direction.Right;
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        if (this.Direction == Direction.Right || this.Direction == Direction.Left) break;
                        this.Direction = Direction.Left;
                        break;
                    }
                default: break;
            }

        }
    }
}
