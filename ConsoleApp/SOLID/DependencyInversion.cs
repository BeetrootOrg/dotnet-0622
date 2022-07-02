interface IA
{
    void MethodA();
}

interface IB
{
    void MethodB();
}

class A : IA
{
    public void MethodA() => System.Console.Write("A");
}

class Bad : IB
{
    private readonly A _a;

    public Bad(A a)
    {
        _a = a;
    }

    public void MethodB() => _a.MethodA();
}

class Best : IB
{
    private readonly IA _a;

    public Best(IA a)
    {
        _a = a;
    }

    public void MethodB() => _a.MethodA();
}