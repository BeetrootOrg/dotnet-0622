// Fibonacci number
const int N = 5;
var result = 0;
int f1 = 1, f2 = 1;
for (int i = f1; i < N; ++i)
{
    result += f1;
    f1 = f2;
    f2 = result;
}
Console.WriteLine($"{N}-th Fibonacci number is {result}");

static int MaxValueAmong(int a, int b) => Math.Max(a, b);
static int MaxValueAmong(int a, int b, int c) => Math.Max(Math.Max(a, b), c);
Console.WriteLine(MaxValueAmong(56, 76));