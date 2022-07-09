namespace ConsoleApp.LibraryDomain;
class Person
{
    public string FirstName { get; set; } = "qwerty";
    public string LastName { get; set; } = "ytrewq";
    public byte Age { get; set; }

    public Person(){}
    public Person(string firstName, string lastName, byte age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override string ToString()
    {
        return ($"Person: {FirstName} {LastName}, age: {Age}.");
    }
}