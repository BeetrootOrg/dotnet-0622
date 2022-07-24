using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public enum eHeading
{
    Up = 0,
    Right = 90,
    Down = 180,
    Left = 270
}

public class Direction
{
    public eHeading Heading { get; private set; }
    public char KeyPress { get; private set; }
    public char HeadToken { get; private set; }
    public int Degrees => (int)Heading;
    public Direction Opposite => Board.DirectionMap.Get((eHeading)(Degrees >= 180 ? Degrees - 180 : Degrees + 180));

    public bool IsUp => Heading == eHeading.Up;
    public bool IsRight => Heading == eHeading.Right;
    public bool IsDown => Heading == eHeading.Down;
    public bool IsLeft => Heading == eHeading.Left;

    public Direction(eHeading vector, char keyPress, char headToken)
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
            _directionKeys = _directionKeys ?? directionKeyMap();
            return _directionKeys;
        }
    }

    private Dictionary<eHeading, Direction> _directionVectors;
    private Dictionary<eHeading, Direction> directionVectors
    {
        get
        {
            _directionVectors = _directionVectors ?? directionVectorMap();
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

    public Direction Get(eHeading vector)
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

    private Dictionary<eHeading, Direction> directionVectorMap()
    {
        return new Dictionary<eHeading, Direction>
            {
                {eHeading.Left, new Direction(eHeading.Left , 'a', '<')},
                {eHeading.Right, new Direction(eHeading.Right,'d', '>') },
                {eHeading.Down, new Direction(eHeading.Down, 's', 'v') },
                {eHeading.Up, new Direction(eHeading.Up, 'w', '^') }
            };
    }

    private Dictionary<char, Direction> directionKeyMap() => directionVectors.ToDictionary(d => d.Value.KeyPress, d => d.Value);
}