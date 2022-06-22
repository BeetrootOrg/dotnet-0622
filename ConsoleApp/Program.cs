using System;

using static System.Console;

string buffer;
WriteLine("X:");
buffer = ReadLine();

if (!int.TryParse(buffer, out var x))
{
    WriteLine("Invalid input");
    return;
}

WriteLine("Y:");
buffer = ReadLine();

if (!int.TryParse(buffer, out var y))
{
    WriteLine("Invalid input");
    return;
}

int sum = 0;
var max = Math.Max(x, y);
for (var i = Math.Min(x, y); i <= max; i++)
{
    sum += i;
}

WriteLine($"Sum = {sum}");