﻿byte micro = 3;
short mini = 2;
int normal = 10;
long elongate = 123;
bool simple = false;
float fract = 0.8621235f;
double dualfract = 681.546813218d;
decimal money = 977.23546816812m;

int x = 37;
int y = 64;

//addition
System.Console.WriteLine(mini + micro);
//subtraction
System.Console.WriteLine(elongate - normal);
//multiplication
System.Console.WriteLine(dualfract * fract);
//negation
System.Console.WriteLine(!simple);
//division
System.Console.WriteLine(money / elongate);
//Output to console result of several math functions:
System.Console.WriteLine(-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15);
System.Console.WriteLine(Math.Abs(x) * Math.Sin(x));
System.Console.WriteLine(2 * Math.PI * x);
System.Console.WriteLine(Math.Max(x, y));
