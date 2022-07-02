using static System.Console;

namespace ConsoleApp;

abstract class Animal
{
    public abstract void Say();
    public int FourtyTwo() => 42;
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

        MakeAnimal42(cat1);
        MakeAnimal42(new Dog());
    }

    private static void MakeAnimalSay(Animal animal) => animal.Say();
    private static void MakeAnimal42(Animal animal) => WriteLine(animal.FourtyTwo());
}