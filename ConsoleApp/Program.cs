static void HelloWorld()
{
    System.Console.WriteLine("Hello, world");
}

static void HelloToSomebody(string somebody) => System.Console.WriteLine($"Hello, {somebody}");

static int Square(int x)
{
    return x * x;
}

static void Add3(int initial)
{
    initial += 3;
}

static void Add5(ref int initial)
{
    initial += 3;
}

HelloWorld();

HelloToSomebody("Dima");
HelloToSomebody("Class");

var square3 = Square(3);
System.Console.WriteLine(square3);

// the same as above
System.Console.WriteLine(Square(3));

var initial = 5;
System.Console.WriteLine("ADD 3");
Add3(initial);
System.Console.WriteLine(initial);

System.Console.WriteLine("ADD 5");
Add5(ref initial);
System.Console.WriteLine(initial);