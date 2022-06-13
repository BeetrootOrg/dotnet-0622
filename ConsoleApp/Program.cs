// 1. create method void WriteLine(int n) and write to console numbers from 1 to n using recurssion
void WriteLine(int n)
{
    if (n <= 0) return;
    WriteLine(n - 1);
    System.Console.Write(n);
}

// 2. create method int Factorial(int n) that will count n! = n * (n - 1) * (n - 2) * ... * 2 * 1, e.g. 5! = 5 * 4 * 3 * 2 * 1 = 120;
int Factorial(int n)
{
    if (n < 0) return -1;
    if (n == 0) return 1;
    return n * Factorial(n - 1);
}

WriteLine(9);
System.Console.WriteLine();
System.Console.WriteLine(Factorial(5));