using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public enum EHeading
{
    Up = 0,
    Right = 90,
    Down = 180,
    Left = 270
}

public class Direction
{
    public EHeading Heading { get; private set; }
    public char KeyPress { get; private set; }
    public char HeadToken { get; private set; }
    public int Degrees => (int)Heading;
    public Direction Opposite => Board.DirectionMap.Get((EHeading)(Degrees >= 180 ? Degrees - 180 : Degrees + 180));

    public bool IsUp => Heading == EHeading.Up;
    public bool IsRight => Heading == EHeading.Right;
    public bool IsDown => Heading == EHeading.Down;
    public bool IsLeft => Heading == EHeading.Left;

    public Direction(EHeading vector, char keyPress, char headToken)
    {
        Heading = vector;
        KeyPress = keyPress;
        HeadToken = headToken;
    }

    public bool IsOpposite(Direction dir) => Math.Abs(Degrees - dir.Degrees) == 180;

    public bool IsSame(Direction dir) => Heading == dir.Heading;

    public string ToCommand() => $"{KeyPress}: {Heading}";
}

public class DirectionMap
{
    private Dictionary<char, Direction> _directionKeys;
    private Dictionary<char, Direction> directionKeys
    {
        get
        {
            _directionKeys = _directionKeys ?? DirectionKeyMap();
            return _directionKeys;
        }
    }

    private Dictionary<EHeading, Direction> _directionVectors;
    private Dictionary<EHeading, Direction> directionVectors
    {
        get
        {
            _directionVectors = _directionVectors ?? DirectionVectorMap();
            return _directionVectors;
        }
    }

    public Direction Get(char c)
    {
        if (directionKeys.TryGetValue(c, out Direction direction))
        {
            return direction;
        }
        else
        {
            throw new Exception($"{c} not found in direction map.");
        }
    }

    public Direction Get(EHeading vector)
    {
        if (directionVectors.TryGetValue(vector, out Direction direction))
        {
            return direction;
        }
        else
        {
            throw new Exception($"Vector {vector.ToString()} not found in direction map.");
        }
    }

    public override string ToString() => string.Join(", ", directionVectors.Select(v => v.Value.ToCommand()));

    private Dictionary<EHeading, Direction> DirectionVectorMap()
    {
        return new Dictionary<EHeading, Direction>
            {
                {EHeading.Left, new Direction(EHeading.Left , 'a', '<')},
                {EHeading.Right, new Direction(EHeading.Right,'d', '>') },
                {EHeading.Down, new Direction(EHeading.Down, 's', 'v') },
                {EHeading.Up, new Direction(EHeading.Up, 'w', '^') }
            };
    }

    private Dictionary<char, Direction> DirectionKeyMap() => directionVectors.ToDictionary(d => d.Value.KeyPress, d => d.Value);
}