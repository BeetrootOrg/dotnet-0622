using static System.Console;

namespace ConsoleApp;

interface IFourtyTwo
{
    int FourtyTwo();
}

class Class42 : IFourtyTwo
{
    public int FourtyTwo() => 42;
}

abstract class Animal
{
    public abstract void Say();
}

class Cat : Animal
{
    public override void Say() => WriteLine("meow");
}

class Dog : Animal
{
    public override void Say() => WriteLine("raf");
}

class Program
{
    private static void Main()
    {
        Animal cat1 = new Cat();
        MakeAnimalSay(cat1);
        MakeAnimalSay(new Dog());

        var fourtyTwo = new Class42();
        Show42(fourtyTwo);
    }

    private static void MakeAnimalSay(Animal animal) => animal.Say();
    private static void Show42(IFourtyTwo fourtyTwo) => WriteLine(fourtyTwo.FourtyTwo());
}