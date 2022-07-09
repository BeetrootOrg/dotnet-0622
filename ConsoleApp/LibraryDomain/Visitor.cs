using ConsoleApp.LibraryDomain;

class Visitor : Person
{
    public string VisitorFirstName { get; set; }
    public string VisitorLastName { get; set; }
    public byte VisitorAge { get; set; }
    private int VisitorID { get; set; }

    public Visitor(string firstName, string lastName, byte age) : base(firstName,lastName,age)
    {
        VisitorFirstName = firstName;
        VisitorLastName = lastName;
        Age = age;
        GetID();
    }
    public override string ToString()
    {
        return ($"Visitor: {FirstName} {LastName}, age: {Age}. Visitor ID: {VisitorID}.");
    }
    private void GetID()
    {
        Random rn = new Random();
        VisitorID = rn.Next(10000,99999);
    }
}