using ConsoleApp.LibraryDomain;

class Staff : Person
{
    private string StaffLastName { get; set; }
    private byte StaffAge { get; set; }
    private string StaffFirstName { get; set; }
    private string Position { get; set; }

    public Staff(string position, string firstName, string lastName, byte age) : base(firstName, lastName, age)
    {
        StaffFirstName = firstName;
        StaffLastName = lastName;
        StaffAge = age;
        Position = position;
    }
    public override string ToString()
    {
        return ($"Staff member: {FirstName} {LastName}, age: {Age}. Position: {Position}.");
    }
}