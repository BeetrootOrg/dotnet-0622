namespace ConsoleApp.School;

class Teacher : Person
{
    public Teacher(string firstName, string lastName,
        string middleName,
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
    public Subject Subject { get; private set; }
    public ClassRoom ClassRoom { get; private set; }

    public string GetNameTeacher() => $"First Name = {FirstName};Last Name = {LastName}; Age = {Age};  Subject = {Subject}; ClassRoom {ClassRoom}";
}