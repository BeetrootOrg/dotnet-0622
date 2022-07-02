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
        Animal cat1 = new Cat();
        MakeAnimalSay(cat1);
    }

    private static void MakeAnimalSay(Animal animal) => animal.Say();
}