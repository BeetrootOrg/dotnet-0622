void WriteLine(int n)
    { 
        if (n <= 0) return;
        WriteLine(n-1);
        System.Console.WriteLine(n);
    }

WriteLine(5);

int Factorial(int n)
{
    if (n == 1) 
    return 1;
 
    return n * Factorial(n - 1);
}

System.Console.WriteLine(Factorial(5));
