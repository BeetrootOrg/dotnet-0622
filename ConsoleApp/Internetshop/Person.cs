namespace ConsoleApp.Internetshop;


abstract class Person : IPerson
{

    public string Firstname { get; init; }
    public string Lastname { get; init; }
    private DateTime _birthday { get; init; }
    private string _email { get; set; }
    public string Gender { get; set; }

    public void AddNewPerson()
    {
        throw new NotImplementedException();
    }

    public void DeletePerson()
    {
        throw new NotImplementedException();
    }
    public void EditPerson()
    {
        throw new NotImplementedException();
    }

}