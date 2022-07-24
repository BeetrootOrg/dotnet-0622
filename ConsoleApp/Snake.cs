using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using ConsoleApp.Interfaces;

namespace ConsoleApp;

enum Direction
{
    Up,
    Right,
    Down,
    Left
}


class SnakeBody : IPositionable, IPositionComparable
{
    public int X => Position.X;
    public int Y => Position.Y;

    public SnakeBody Next { get; private set; }

    protected Point Position;

    public SnakeBody(IPositionable position)
    {
        Position = new Point
        {
            X = position.X,
            Y = position.Y
        };
    }

    public void Move(Point position)
    {
        if (Next != null)
        {
            Next.Move(Position);
        }

        Position = new Point(position);
    }

    public void Append(SnakeBody snakeBody)
    {
        Next = snakeBody;
    }

    public bool SamePosition(IPositionable positionable)
    {
        return Position.SamePosition(positionable);
    }
}

class SnakeHead : SnakeBody
{
    public SnakeHead(Point position) : base(position)
    {
    }

    public void Move(Direction direction)
    {
        Next.Move(Position);

        switch (direction)
        {
            case Direction.Up:
                Position = Position.Up();
                break;
            case Direction.Down:
                Position = Position.Down();
                break;
            case Direction.Left:
                Position = Position.Left();
                break;
            case Direction.Right:
                Position = Position.Right();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(direction));
        }
    }
}

class Snake : IEnumerable<SnakeBody>, IEater, IPositionable, IPositionComparable
{
    public int X => _head.X;

    public int Y => _head.Y;

    private readonly SnakeHead _head;

    private Snake(SnakeHead head)
    {
        _head = head;
    }

    public void Move(Direction direction)
    {
        _head.Move(direction);
    }

    public bool SamePosition(IPositionable positionable)
    {
        return this.Any(b => b.SamePosition(positionable));
    }

    public IEnumerator<SnakeBody> GetEnumerator() => AllBody().GetEnumerator();

    public void Eat(IConsumable consumable)
    {
        var effect = consumable.Consume();

        if (effect is ISnakeEffect snakeEffect)
        {
            snakeEffect.AffectSnake(this);
        }
    }

    public void Grow()
    {
        var latest = this.Last();
        latest.Append(new SnakeBody(latest));
    }

    public static Snake Create(int size = 3)
    {
        var head = new SnakeHead(new Point(size, 1));
        SnakeBody lastBodyPart = head;

        for (var i = 1; i < size; ++i)
        {
            var bodyPart = new SnakeBody(new Point
            {
                X = size - i,
                Y = 1
            });

            lastBodyPart.Append(bodyPart);
            lastBodyPart = bodyPart;
        }

        return new Snake(head);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private IEnumerable<SnakeBody> AllBody()
    {
        SnakeBody part = _head;
        while (part != null)
        {
            yield return part;
            part = part.Next;
        }
    }
}