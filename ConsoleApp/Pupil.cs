namespace ConsoleApp;
class Pupil
{
    public string FirstName {get; init;}
    public string LastName {get; init;}
    public DateTime DateBirth {get; init;}
    public string SchoolClass {get; init;}
    
    public Pupil()
    {
        
        Console.WriteLine ("Pupil Constructor");
    }

}