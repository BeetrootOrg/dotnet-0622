using static System.Console;

namespace ConsoleApp.SOLID;

class SingleResponsibilityBad
{
    public int SumAndShow(int a, int b)
    {
        var sum = a + b;
        WriteLine(sum);
        return sum;
    }
}

class SingleResponsibilityBetterButBad
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public void Show(int sum)
    {
        WriteLine(sum);
    }
}

class SingleResponsibilityBest1
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}

class SingleResponsibilityBest2
{
    public void Show(object sum)
    {
        WriteLine(sum);
    }
}