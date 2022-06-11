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

static bool TryParseInt(string str, out int result) => int.TryParse(str, out result);
static bool TryDivideBy3(int number, out int result)
{
    if (number % 3 == 0)
    {
        result = number / 3;
        return true;
    }

    result = 0;
    return false;
}

static bool TryDivideBy4(int number, out int result)
{
    result = number / 4;
    return number % 4 == 0;
}

static void TryRef(ref int value)
{
    if (value > 10)
    {
        value += 20;
    }
}

// Compilation error
// static void TryOut(out int value)
// {
//     if (value > 10)
//     {
//         value += 20;
//     }
// }

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

// parsing
var success = TryParseInt("42", out var result);
System.Console.WriteLine($"Success: {success}. Result: {result}");

success = TryDivideBy3(6, out initial);
System.Console.WriteLine($"Success: {success}. Result: {initial}");

success = TryDivideBy3(7, out initial);
System.Console.WriteLine($"Success: {success}. Result: {initial}");

success = TryDivideBy4(8, out initial);
System.Console.WriteLine($"Success: {success}. Result: {initial}");

success = TryDivideBy4(9, out initial);
System.Console.WriteLine($"Success: {success}. Result: {initial}");

TryRef(ref initial);
System.Console.WriteLine(initial);
initial = 30;
TryRef(ref initial);
System.Console.WriteLine(initial);

// Compilation error
// int newValue;
// TryRef(ref newValue);