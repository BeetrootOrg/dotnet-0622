using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public class Cell
{
    private readonly char _unitializedToken = char.MinValue;
    private readonly char _emptyToken = ' ';
    private readonly char _borderToken = '*';
    private readonly char _bodyToken = 'X';
    private readonly char _foodToken = 'Y';

    private int _remaining;

    public int X { get; private set; }
    public int Y { get; private set; }
    public char Value { get; private set; }

    public bool IsBorder => Value == _borderToken;
    public bool IsBody => Value == _bodyToken;
    public bool IsFood => Value == _foodToken;
    public bool IsEmpty => Value == _emptyToken || Value == _unitializedToken;
    public bool IsForbidden => IsBorder || IsBody;

    public Cell(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void SetEmpty() => Update(_emptyToken);

    public void SetHead(char headToken)
    {
        Update(headToken);
    }

    public void SetBody(int length)
    {
        Update(_bodyToken);
        _remaining = length;
    }

    public void SetBorder() => Update(_borderToken);

    public void SetFood() => Update(_foodToken);

    public void Update(char newVal) => Value = newVal;

    public void Decay()
    {
        if (--_remaining == 0)
        {
            SetEmpty();
        }
    }

    public override string ToString() => $"{X}, {Y}";
}