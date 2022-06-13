static int MultiplyWorst(int a)
{
    if (a >= 10)
    {
        return a * 10;
    }
    else if (a < 10)
    {
        return a * 20;
    }

    return a;
}

static int MultiplyWorse(int a)
{
    if (a >= 10)
    {
        return a * 10;
    }

    if (a < 10)
    {
        return a * 20;
    }

    return a;
}


static int Multiply(int a) => a >= 10 ? a * 10 : a * 20;

System.Console.WriteLine(MultiplyWorst(20));
System.Console.WriteLine(MultiplyWorse(20));
System.Console.WriteLine(Multiply(20));
