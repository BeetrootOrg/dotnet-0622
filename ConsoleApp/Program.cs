using static System.Console;

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

    public void Say() => WriteLine("<<placeholder>>");
}

class Dog : Animal
{
}

enum Breed
{
    SimpleFree,
    Sphynx,
    Red
}

class Cat : Animal
{
    public Breed Breed { get; set; }
}