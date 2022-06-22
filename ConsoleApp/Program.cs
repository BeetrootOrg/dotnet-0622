using System;

var x = 3;
Console.WriteLine($"x^3={x}");
Console.WriteLine($"x*x*x={x * x * x}");
Console.WriteLine($"Math.Pow(x, 3)={Math.Pow(x, 3)}");
Console.WriteLine($"WRONG: -6*x^3+5*x^2-10*x+15={-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15}");
Console.WriteLine($"RIGHT: -6*x^3+5*x^2-10*x+15={-6 * x * x * x + 5 * x * x - 10 * x + 15}");

var now = DateTime.Now;
var nextNewYear = new DateTime(2023, 1, 1);

Console.WriteLine($"{(nextNewYear - now).Days} days left to New Year");
Console.WriteLine($"{now.DayOfYear} days passed from New Year");