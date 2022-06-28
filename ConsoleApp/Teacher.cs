namespace ConsoleApp;
class Teacher
{
    public string FirstName {get; init;}
    string LastName {get; init;}
    DateTime DateBirth {get; init;}
    string Subject {get; init;}

    public Teacher ()
    {
        Console.WriteLine ("Teacher Construcotr");
    }
}
