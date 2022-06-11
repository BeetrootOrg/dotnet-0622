static void HelloWorld()
{
    System.Console.WriteLine("Hello, world");
}

static void HelloToSomebody(string somebody)
{
    System.Console.WriteLine($"Hello, {somebody}");
}

HelloWorld();

HelloToSomebody("Dima");
HelloToSomebody("Class");