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

int MultiplyBest(int a) => a >= 10 ? a * 10 : a * 20;
int Multiply(int a, int b) => a * b;
int MultiplyThree(int a, int b, int c) => Multiply(Multiply(a, b), c); // the same as a * b * c
int Sum(int a, int b) => a + b;

System.Console.WriteLine(MultiplyWorst(20));
System.Console.WriteLine(MultiplyWorse(20));
System.Console.WriteLine(MultiplyBest(20));

string str = "hello";
string concatenated = "hello" + "," + "Yurii";
concatenated = $"{str}, Yurii";

string example = "example     f";
System.Console.WriteLine(example.TrimEnd('f'));
System.Console.WriteLine(example.Substring(0, example.Length -1));

// (5 + 6) * (4 + 5)
var result1 = Sum(5, 6);
var result2 = Sum(4, 5);
var result = Multiply(result1, result2);
System.Console.WriteLine($"(5 + 6) * (4 + 5) = {result}");

//the same as above
System.Console.WriteLine($"(5 + 6) * (4 + 5) = {Multiply(Sum(5, 6), Sum(4, 5))}");

char c = 'c';
System.Console.WriteLine((int)c);

System.Console.WriteLine('c' + 'a');
System.Console.WriteLine($"{c}{c}");
System.Console.WriteLine("something" + c);
System.Console.WriteLine(c + "something");
