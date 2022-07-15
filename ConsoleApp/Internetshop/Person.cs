namespace ConsoleApp.Internetshop;


abstract class Person : IPerson
{
    public string Firstname;
    public string Lastname;
    private DateTime _birthday;
    private string _email;
    public string Gender;

    virtual public void AddNewPerson()
    {
        throw new NotImplementedException();
    }

    virtual public void DeletePerson()
    {
        throw new NotImplementedException();
    }
    virtual public void EditPerson()
    {
        throw new NotImplementedException();
    }

}