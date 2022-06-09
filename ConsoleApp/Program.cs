Console.WriteLine("Please type in your first number: ");
string xString = Console.ReadLine();
int xNubmer;
bool xSuccess = int.TryParse(xString, out xNubmer);

if (xSuccess == true)
{
    Console.WriteLine($"Your number is {xNubmer}");
}
else 
{
    Console.WriteLine("Invalid input, exiting the program");
    Environment.Exit(0);
}

Console.WriteLine("Please type in your second number: ");
var yString = Console.ReadLine();
int yNubmer;
bool ySuccess = int.TryParse(yString, out yNubmer);

if (ySuccess == true)
{
    Console.WriteLine($"Your number is {yNubmer}");
}
else 
{
    Console.WriteLine("Invalid input, exiting the program");
    Environment.Exit(0);
}

int sum = 0;
if (xNubmer < yNubmer && xNubmer != yNubmer)
{
    for (int i = xNubmer; i <= yNubmer; i++)
    {
        sum += i;
    }

    Console.WriteLine(sum);
}   
else if (xNubmer > yNubmer && xNubmer != yNubmer)
{
    for (int i = yNubmer; i <= xNubmer; i++)
    {
        sum += i;
    }

    Console.WriteLine(sum);
}
else
{
    sum = xNubmer;
    Console.WriteLine($"You have entered same numbers {sum}!");
}