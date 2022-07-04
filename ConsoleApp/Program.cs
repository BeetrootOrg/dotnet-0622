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

WriteLine($"vector1.ToString() = {vector1}");
WriteLine($"vector1.Equals(vector2) = {vector1.Equals(vector2)}");
// Compilation error below
// WriteLine($"vector1 == vector2 = {vector1 == vector2}");
WriteLine($"vector1.GetHashCode() = {vector1.GetHashCode()}");
WriteLine($"vector2.GetHashCode() = {vector2.GetHashCode()}");