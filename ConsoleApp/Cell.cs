using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame;
public class Cell
{
    private readonly char unitializedToken = char.MinValue;
    private readonly char emptyToken = ' ';
    private readonly char borderToken = '*';
    private readonly char bodyToken = 'X';
    private readonly char foodToken = 'Y';

    private int remaining;

    public int X { get; private set; }
    public int Y { get; private set; }
    public char Value { get; private set; }

    public bool IsBorder => Value == borderToken;
    public bool IsBody => Value == bodyToken;
    public bool IsFood => Value == foodToken;
    public bool IsEmpty => Value == emptyToken || Value == unitializedToken;
    public bool IsForbidden => IsBorder || IsBody;

    public Cell(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void SetEmpty() => Update(emptyToken);

    public void SetHead(char headToken)
    {
        Update(headToken);
    }

    public void SetBody(int length)
    {
        Update(bodyToken);
        remaining = length;
    }

    public void SetBorder() => Update(borderToken);

    public void SetFood() => Update(foodToken);

    public void Update(char newVal) => Value = newVal;

    public void Decay()
    {
        if (--remaining == 0)
        {
            SetEmpty();
        }
    }

    public override string ToString() => $"{X}, {Y}";
}