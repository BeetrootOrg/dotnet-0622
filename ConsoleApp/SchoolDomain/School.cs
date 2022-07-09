namespace ConsoleApp.SchoolDomain;
class School
{
    public string Name { get; init; }
    public string Address { get; init; }
    public string  Email { get; init; }
    public string PhoneNumber { get; init; }
    private int _classroom;

      public int Classroom
    {
        get => _classroom;
        set => _classroom = value;
    }

    public School(string name, string address, string email, string phoneNumber, int classroom)
    {
        Name = name;
        Address = address;
        Email = email;
        PhoneNumber = phoneNumber;
        Classroom = classroom;
    }


}