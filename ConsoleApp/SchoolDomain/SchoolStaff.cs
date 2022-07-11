enum Staff
{
    Director,
    Janitor,
    Cheef,
    Security,
    Teacher
}
class SchoolStaff : Person
{
    public string StaffFirstName { get; set; } = "";
    public string StaffLastName { get; set; } = "";
    public int StaffAge { get; set; }
    protected decimal Salary { get; set; }
    private Staff Position { get; set; }
    public SchoolStaff(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = CountSalary();
        Position = SetPosition();
    }
    protected virtual decimal CountSalary()
    {
        throw new NotImplementedException();
    }
    private Staff SetPosition()
    {
        throw new NotImplementedException();
    }
}