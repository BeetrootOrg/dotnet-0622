namespace ConsoleApp.School;

class Teacher
{
    public string FirstName { get; init; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; init; }
    public string Subject { get; set; }
    public string Position { get; set; }

    public Teacher(string firstName, string lastName, DateTime dateOfBirth, string subject, string position)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Subject = subject;
        Position = position;
    }
    public Teacher UpdateTeacherLastName(string newLastName)
    {
        LastName = newLastName;
        return this;
    }
    public Teacher UpdateTeacherSubject(string newSubject)
    {
        Subject = newSubject;
        return this;
    }
        public Teacher UpdateTeacherPosition(string newPosition)
    {
        Position = newPosition;
        return this;
    }
}