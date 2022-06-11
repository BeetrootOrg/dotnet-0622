﻿
System.Console.Write("Input first num(only numbers):");
var num1 = Console.ReadLine();
System.Console.Write("Input second num(only numbers):");
var num2 = Console.ReadLine();

if(num1 == num2) System.Console.WriteLine($"Numbers are equal {num1}"); //or System.Console.WriteLine($"Numbers are equal");

else if (int.TryParse(num1, out int pNumber1) && int.TryParse(num2, out int pNumber2))
{
    GetSum(pNumber1,pNumber2);
}

else
{
    System.Console.WriteLine("You're stupid!");
    System.Console.WriteLine("Press any button to exit the program...");
    Console.ReadKey();
    Environment.Exit(0);
}


void GetSum(int a, int b)
{
    int sum = 0;
    int num1 = Math.Min(a,b);
    int num2 = Math.Max(a,b);
    for (int i = num1; i <= num2; ++i)
    {
        sum += i;
    }
    System.Console.WriteLine($"Sum from {a} to {b} = {sum}");
}


