using System.Collections;
using System.Collections.Generic;

using ConsoleApp.Interfaces;

namespace ConsoleApp;

class FieldBorder : IConsumable, IPositionComparable, IEnumerable<Point>
{
    public int Size { get; init; } = 15;

    public IEffect Consume()
    {
        return DieEffect.Instance;
    }

    public IEnumerator<Point> GetEnumerator() => Border().GetEnumerator();

    public bool SamePosition(IPositionable positionable)
    {
        return positionable.X == 0 || positionable.X == Size - 1 ||
            positionable.Y == 0 || positionable.Y == Size - 1;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private IEnumerable<Point> Border()
    {
        for (var i = 0; i < Size; ++i)
        {
            yield return new Point(0, i);
            yield return new Point(Size - 1, i);
            yield return new Point(i, 0);
            yield return new Point(i, Size - 1);
        }
    }
}