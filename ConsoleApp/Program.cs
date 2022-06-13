int MultiplyWorst(int a)
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

int MultiplyWorse(int a)
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


int Multiply(int a) => a >= 10 ? a * 10 : a * 20;

System.Console.WriteLine(MultiplyWorst(20));
System.Console.WriteLine(MultiplyWorse(20));
System.Console.WriteLine(Multiply(20));

string str = "hello";
string concatenated = "hello" + ", " + "Dima";
concatenated = $"{str}, Dima";

string example = "example    f";
System.Console.WriteLine(example.TrimEnd('f'));
System.Console.WriteLine(example.Substring(0, example.Length - 1));

System.Console.WriteLine(string.Format("{0}, {1}. {0}, {2}", "Hello", "Dima", "Class"));
