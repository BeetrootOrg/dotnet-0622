// 1. create method WriteLine(int n) and write to console numbers from 1 to n using recurssion
// 2. create method Factorial(int n) that will count n! = n * (n - 1) * (n - 2) * ... * 2 * 1, e.g. 5! = 5 * 4 * 3 * 2 * 1 = 120;
static void WriteLineN(int n)
{
    int x = 0;
    for (int i = x; i < n ; ++i)
    {
        System.Console.Write(++x);
    }
   
}

WriteLineN(10);
// static void WriteLineN(int n)
// {
//     if (n == 1) return;
//     {
//         System.Console.Write(n);
//     }
//     Console.Write(WriteLineN(n - 1));
// }
