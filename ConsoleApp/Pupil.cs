namespace ConsoleApp;
class Pupil : Person
{
    public SchoolClass SchoolClass {get; init;}
    
    public Pupil()
    {
        
        Console.WriteLine ("Pupil Constructor");
    }

    public string GetPerson() => $"{base.GetPerson()}; School Class = {SchoolClass}";

}