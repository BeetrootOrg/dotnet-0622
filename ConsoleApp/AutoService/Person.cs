namespace ConsoleApp.AutoService;

class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

      virtual public void Say()
      {
        System.Console.WriteLine("Hello, how are you?");
      }

}