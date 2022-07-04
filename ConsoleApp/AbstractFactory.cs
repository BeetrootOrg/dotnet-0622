namespace ConsoleApp;

public interface IA
{
    void MethodA();
}

class A1 : IA
{
    public void MethodA()
    {
        System.Console.WriteLine("I am A1");
    }
}

class A2 : IA
{
    public void MethodA()
    {
        System.Console.WriteLine("A2 I am");
    }
}

public interface IFactory
{
    IA CreateA();
}

public class Factory1 : IFactory
{
    public IA CreateA() => new A1();
}

public class Factory2 : IFactory
{
    public IA CreateA() => new A1();
}