using static System.Console;

namespace ConsoleApp;

interface IFourtyTwo
{
    int FourtyTwo();
}

interface ISum
{
    int Sum(int a, int b);
}

class Class42 : IFourtyTwo, ISum
{
    public int FourtyTwo() => 42;

    public int Sum(int a, int b) => a + b;
}

abstract class Animal
{
    public abstract void Say();
    public void MakeStunt()
    {
        WriteLine("Prepare for the stunt...");
        MakeStuntInternal();
        WriteLine("DONE! BRAVO!");
    }

    protected virtual void MakeStuntInternal() => WriteLine("No stunt :(");
}

class Cat : Animal
{
    public override void Say() => WriteLine("meow");

    protected override void MakeStuntInternal() => WriteLine("IM ON TWO LEGS, BITCH");
}

class Dog : Animal
{
    public override void Say() => WriteLine("raf");

    protected override void MakeStuntInternal() => WriteLine("RAF RAF, I'M DANGER");
}

class Cockroach : Animal
{
    public override void Say() => WriteLine("raf");
}

class Program
{
    private static void Main()
    {
        Animal cat1 = new Cat();
        Dog dog1 = new Dog();

        MakeAnimalSay(cat1);
        MakeAnimalSay(dog1);

        MakeAnimalStunt(cat1);
        MakeAnimalStunt(dog1);
        MakeAnimalStunt(new Cockroach());

        var fourtyTwo = new Class42();
        Show42(fourtyTwo);
        ShowSum(fourtyTwo);
    }

    private static void MakeAnimalSay(Animal animal) => animal.Say();
    private static void MakeAnimalStunt(Animal animal) => animal.MakeStunt();
    private static void Show42(IFourtyTwo fourtyTwo) => WriteLine(fourtyTwo.FourtyTwo());
    private static void ShowSum(ISum sum) => WriteLine(sum.Sum(3, 5));
}