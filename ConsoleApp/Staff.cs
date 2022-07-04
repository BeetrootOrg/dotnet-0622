namespace ConsoleApp;

class Staff : Person
{
    public DateTime DateBirth {get; init;} 
    public String Passport {get; init;}    

    public override void GetPerson()
    {
        //all parameters about person

    }
}