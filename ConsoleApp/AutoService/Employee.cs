namespace ConsoleApp.AutoService;

class Employee : Person
{
    public string JobTitle { get; init; }
    private int Age { get; init; }


    public override void Say()
    {
        System.Console.WriteLine("Good afternoon. Welcome to our car service! How can I help you?");
    }

}