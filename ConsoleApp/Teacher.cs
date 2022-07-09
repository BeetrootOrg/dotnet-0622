namespace ConsoleApp.School;

class Teacher
{
    public string FirstName { get; init; }
    public string LastName { get; set; }
    public string Subject { get; set; }


    public Teacher(string firstName, string lastName, string subject)
    {
        FirstName = firstName;
        LastName = lastName;
        Subject = subject;
    }
    public Teacher SubjectUpdate(string newSubject)
    {
        Subject = newSubject;
        return this;
    }
}