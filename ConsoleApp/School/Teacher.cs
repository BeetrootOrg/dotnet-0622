namespace ConsoleApp.School;

class Teacher : Person
{
    public Teacher(string firstName, string lastName, string middleName,
        byte age,
        Subject subject,
        ClassRoom classRoom)
    {
        firstName = FirstName;
        lastName = LastName;
        middleName = MiddleName;
        age = Age;
        subject = Subject;
        classRoom = ClassRoom;
    }
    public string MiddleName { get; set; }
    public Subject Subject { get; set; }
    public ClassRoom ClassRoom { get; set; }
}