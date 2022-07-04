namespace ConsoleApp;
abstract class Person
{
    public string FirstName {get; init;}
    public string LastName {get; init;}

   abstract public void GetPerson();

}