using ConsoleApp;

using static System.Console;

var vector1 = new Vector
{
    X = 5,
    Y = 10
};

var vector2 = new Vector
{
    X = 5,
    Y = 10
};

var vector3 = new Vector(1, 2);
var vector4 = new Vector(3, 4);

WriteLine($"vector1.ToString() = {vector1}");
WriteLine($"vector1.Equals(vector2) = {vector1.Equals(vector2)}");
WriteLine($"vector1 == vector2 = {vector1 == vector2}");
WriteLine($"vector1 != vector3 = {vector1 != vector3}");
WriteLine($"vector1.GetHashCode() = {vector1.GetHashCode()}");
WriteLine($"vector2.GetHashCode() = {vector2.GetHashCode()}");
WriteLine($"vector1 + vector3 = {vector1 + vector3}");
WriteLine($"vector1 - vector3 = {vector1 - vector3}");
WriteLine($"vector1[X] = {vector1[Dimension.X]}");
WriteLine($"vector1[0] = {vector1[(Dimension)0]}");
WriteLine($"vector1[Y] = {vector1[Dimension.Y]}");
WriteLine($"vector1[1] = {vector1[(Dimension)1]}");
WriteLine($"vector1[X, X] = {vector1[Dimension.X, Dimension.X]}");
WriteLine($"vector1[Y, Y] = {vector1[Dimension.Y, Dimension.Y]}");
// ArgumentOutOfRangeException below
// WriteLine($"vector1[42] = {vector1[(Dimension)42]}");

ShowLength(vector4);
ShowRoundedLength((int)vector1);

void ShowLength(double length)
{
    WriteLine($"Length of vector = {length}");
}

void ShowRoundedLength(int length)
{
    WriteLine($"Rounded Length of vector = {length}");
}
