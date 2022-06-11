static void HelloWorld()
{
    System.Console.WriteLine("Hello, world");
}

static void HelloToSomebody(string somebody) => System.Console.WriteLine($"Hello, {somebody}");

static int Square(int x)
{
    return x * x;
}

HelloWorld();

HelloToSomebody("Dima");
HelloToSomebody("Class");

var square3 = Square(3);
System.Console.WriteLine(square3);

// the same as above
System.Console.WriteLine(Square(3));