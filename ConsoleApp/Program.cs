using static System.Console;

namespace ConsoleApp;

abstract class Animal
{
    public abstract void Say();
}

class Cat : Animal
{
    public override void Say() => WriteLine("meow");
}

class Program
{
    private static void Main()
    {
        var cat1 = new Cat();
        cat1.Say();
    }
}