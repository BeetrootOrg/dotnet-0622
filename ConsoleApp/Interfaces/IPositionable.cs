namespace ConsoleApp.Interfaces;

interface IPositionable
{
    int X { get; }
    int Y { get; }
}

interface IPositionComparable
{
    bool SamePosition(IPositionable positionable);
}