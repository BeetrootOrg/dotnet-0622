using static System.Console;

void Swap<T>(ref T val1, ref T val2)
{
    var temp = val1;
    val1 = val2;
    val2 = temp;
}

var a = 1;
var b = 2;
Swap(ref a, ref b);

WriteLine($"a = {a}");
WriteLine($"b = {b}");

var c = "hello";
var d = "world";

Swap(ref c, ref d);

WriteLine($"c = {c}");
WriteLine($"d = {d}");

IJob<string, object> class1 = new ConvertToStringJob();
IJob<decimal, decimal> class2 = new MultiplyBy10();
IJob<string, decimal> class3 = new ConvertNumbersToStringJob();

WriteLine(class1.Execute(5));
WriteLine(class2.Execute(5));
WriteLine(class3.Execute(42.123456m));

IA<string> a1 = new A();
IA<object> a2 = a1;

object result = a2.DoSomething();

IB<object> b1 = new B();
IB<string> b2 = b1;

b2.DoSomething("Hello, world");

interface IA<out TOut>
{
    TOut DoSomething();
}

interface IB<in TIn>
{
    void DoSomething(TIn input);
}

class A : IA<string>
{
    public string DoSomething() => "Hello";
}

class B : IB<object>
{
    public void DoSomething(object input) => WriteLine(input);
}

interface IJob<out TOut, in TIn>
{
    TOut Execute(TIn input);
}

class ConvertToStringJob : IJob<string, object>
{
    public string Execute(object input) => input.ToString();
}

class ConvertNumbersToStringJob : IJob<string, decimal>
{
    public string Execute(decimal input) => input.ToString("F2");
}

class MultiplyBy10 : IJob<decimal, decimal>
{
    public decimal Execute(decimal input) => input * 10;
}
