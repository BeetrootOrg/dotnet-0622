﻿
byte b1 = 255;
short s1 = 10;
int i1 = 12;
long l1 = 20;
float f1 = 20.123f;
double d1 = 44.52d;
decimal dd1 = 251.553m;


System.Console.WriteLine("Task #1");
System.Console.WriteLine(b1 + s1);
System.Console.WriteLine(b1 + dd1);
System.Console.WriteLine(f1 * d1);
System.Console.WriteLine(b1 - f1);
System.Console.WriteLine(dd1 - b1);
System.Console.WriteLine(i1 + l1);
System.Console.WriteLine(b1 + s1 * l1 - dd1);


System.Console.WriteLine("Task Extra");
DateTime date = DateTime.Today;
DateTime pastYear = new DateTime(2022,01,01);
DateTime followingYear = new DateTime(2023,01,01);
TimeSpan days;

days = date.Subtract(pastYear);
System.Console.WriteLine($"{days.Days} days paseed from New Year");
days = followingYear.Subtract(date);
System.Console.WriteLine($"{days.Days} days left to New Year");
