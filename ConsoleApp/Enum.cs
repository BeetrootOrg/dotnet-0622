using System;

namespace ConsoleApp;

public enum Color
{
    Black,
    Red,
    Yellow,
    Blue
}

public class EnumExample
{
    public void PrintInColor(Color color)
    {
        switch (color)
        {
            case Color.Black:
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case Color.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(color));
        }
    }
}