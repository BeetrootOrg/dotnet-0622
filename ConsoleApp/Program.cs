const int N = 10;
var result = 0;
int f1 = 1, f2 = 1;
for (int i = f1; i <= N; ++i)
{
    if (i == N && i != 1)
    {
        break;
    }
    result += f1;
    f1 = f2;
    f2 = result;
}
System.Console.WriteLine(result);