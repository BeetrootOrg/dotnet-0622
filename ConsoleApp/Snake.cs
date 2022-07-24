using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using ConsoleApp.Interfaces;

namespace ConsoleApp;

class SnakeBody : IPositionable, IPositionComparable, IConsumable
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
        if (!position.SamePosition(this) && !position.IsNeighbor(this))
        {
            throw new Exception("Cannot teleport");
        }

        if (Next != null)
        {
            Next.Move(Position);
        }

        Position = new Point(position);
    }

    public void Append(SnakeBody snakeBody)
    {
        if (Next != null)
        {
            throw new Exception("Cannot cut snake");
        }

        Next = snakeBody;
    }

    public bool SamePosition(IPositionable positionable)
    {
        return Position.SamePosition(positionable);
    }

    public IEffect Consume()
    {
        return DieEffect.Instance;
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
    public int X => Head.X;

    public int Y => Head.Y;

    public SnakeHead Head { get; }
    public IEnumerable<SnakeBody> Body => this.Skip(1);

    private Snake(SnakeHead head)
    {
        Head = head;
    }

    public void Move(Direction direction)
    {
        Head.Move(direction);
    }

    public bool SamePosition(IPositionable positionable)
    {
        return this.Any(b => b.SamePosition(positionable));
    }

    public IEnumerator<SnakeBody> GetEnumerator() => WholeSnake().GetEnumerator();

    public void Eat(IConsumable consumable)
    {
        var effect = consumable.Consume();
        effect.Affect(this);
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

    private IEnumerable<SnakeBody> WholeSnake()
    {
        SnakeBody part = Head;
        while (part != null)
        {
            yield return part;
            part = part.Next;
        }
    }
}