using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public class Snake
{
    private readonly int maxSpeed = 5;
    private readonly int delayMultiplier = 700;

    public Cell Head { get; private set; }
    public LinkedList<Cell> Body { get; private set; }
    public Cell Tail => Body.Last();
    public Direction Direction { get; private set; }
    public int Length => BodyLength + 1;
    public int BodyLength => Body.Count;
    public int Speed { get; private set; }
    public bool HasEaten { get; private set; }

    public Snake(Cell head, LinkedList<Cell> body, Direction initialHeading, int speed = 1)
    {
        Head = head;
        Body = body;
        Speed = Math.Min(speed, maxSpeed);
        Direction = initialHeading;
        Head.SetHead(Direction.HeadToken);
    }

    public void Move(Direction direction, Cell nextHead)
    {
        var originalHead = Head;

        Direction = direction;

        HasEaten = false;

        if (nextHead.IsFood)
        {
            Eat();
        }

        Head = nextHead;

        Head.SetHead(direction.HeadToken);

        moveBody(originalHead);

        pause();
    }

    public void Eat()
    {
        HasEaten = true;
    }

    public void Grow(Cell newTail)
    {
        newTail.SetBody(1);
        Body.AddLast(newTail);
    }

    private void moveBody(Cell originalHead)
    {
        foreach (var cell in Body)
        {
            cell.Decay();
        }
        Body.AddFirst(originalHead);
        originalHead.SetBody(BodyLength - 1);
        Body.RemoveLast();
    }

    private void pause() => Thread.Sleep(maxSpeed - Speed + 1 * delayMultiplier);
}