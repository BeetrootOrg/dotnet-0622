namespace ConsoleApp.School;

class Teacher
{
    public Person TeacherInfo { get; init; }
    public int Salary { private get; init; }
    public Subject SubjectThatTeaches { get; set; }
}