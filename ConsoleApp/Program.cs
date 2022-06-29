﻿using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        var animal1 = new Animal
        {
            EyesColor = EyesColor.Black,
            Lifestyle = Lifestyle.Meat,
            Size = Size.Large,
            Name = "animal"
        };

        var cat1 = new Cat
        {
            Breed = Breed.Red,
            EyesColor = EyesColor.Brown,
            Lifestyle = Lifestyle.Meat,
            Name = "Grafield",
            Size = Size.XLarge
        };

        var cat2 = new Cat
        {
            Breed = Breed.SimpleFree,
            EyesColor = EyesColor.Black,
            Lifestyle = Lifestyle.Grass,
            Name = "Casper",
            Size = Size.Medium
        };

        animal1.Say();
        cat1.Say();

        Animal animal2 = cat1;
        // below is possible as well
        // animal2 = new Dog();

        animal2.Say();

        A b = new B();
        A d = new D();
        b.Method();
        d.Method();

        CallMethod(new A());
        CallMethod(new B());
        CallMethod(new C());
        CallMethod(new D());

        MakeAnimalSaySomething(animal1);
        MakeAnimalSaySomething(cat1);
        MakeAnimalSaySomething(new Dog());

        WriteLine("BAD");
        MakeAnimalSaySomethingBad(animal1);
        MakeAnimalSaySomethingBad(cat1);
        MakeAnimalSaySomethingBad(new Dog());

        WriteLine("SIZES");
        WriteLine(cat1.GetSize());
        WriteLine(cat2.GetSize());
    }

    static void CallMethod(A instance) => instance.Method();
    static void MakeAnimalSaySomething(Animal animal) => animal.Say();
    static void MakeAnimalSaySomethingBad(Animal animal) => animal.SayBad();
}

enum Lifestyle
{
    Grass,
    Meat
}

enum EyesColor
{
    Black,
    Brown,
    Red
}

enum Size
{
    Small,
    Medium,
    Large,
    XLarge
}

class Animal
{
    public Lifestyle Lifestyle { get; set; }
    public EyesColor EyesColor { get; set; }
    public Size Size { get; set; }
    public string Name { get; set; }

    public virtual void Say() => WriteLine("<<placeholder>>");
    public void SayBad() => WriteLine("<<placeholder>>");

    public virtual int GetSize() => Size switch
    {
        Size.Small => 1,
        Size.Medium => 2,
        Size.Large => 4,
        Size.XLarge => 8,
        _ => -1
    };
}

class Dog : Animal
{
}

class Cat : Animal
{
    public Breed Breed { get; set; }

    public override void Say() => WriteLine("meow");
    public new void SayBad() => WriteLine("meow");

    public override int GetSize() => Size switch
    {
        Size.XLarge => 16,
        _ => base.GetSize()
    };
}

enum Breed
{
    SimpleFree,
    Sphynx,
    Red
}

class A
{
    public virtual void Method() => WriteLine("A");
}

class B : A
{
}

class C : B
{
    public override void Method() => WriteLine("C");
}

class D : C
{
}