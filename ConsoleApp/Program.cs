﻿byte firstvalue = 11;
short secondvalue = 3214;
int thirdvalue = 423123;
long fourthvalue = 1235412351;
bool fifthvalue = true;
float sixthvalue = 2.2f;
double seventhvalue = 3.7f;
decimal eighthvalue = 12.8M;

    Console.WriteLine("First part of homework");
    Console.WriteLine();                                                        // просто для пробілу при виводі
    Console.WriteLine("int + short: " + thirdvalue + secondvalue);
    Console.WriteLine();
    Console.WriteLine("long + int: " + (fourthvalue - thirdvalue));
    Console.WriteLine();
    Console.WriteLine("decimal * byte: " + eighthvalue * firstvalue);

    Console.WriteLine();

int x = 14;
int y = 73;

    Console.WriteLine("Second part of homework");
    Console.WriteLine();
    Console.WriteLine("Math.Max(x,y): " + Math.Max(x, y));
    Console.WriteLine();
    Console.WriteLine("2*Pi*x: " + 2 * Math.PI * x);
    Console.WriteLine();
    Console.WriteLine("abs(x)*sin(x): " + Math.Abs(x) * Math.Sin(x));
    Console.WriteLine();
    Console.WriteLine("-6*x^3+5*x^2-10*x+15: " + (-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15));