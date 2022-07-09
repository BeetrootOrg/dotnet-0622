namespace ConsoleApp.SchoolDomain;

class Schedule
{
    public Teacher Teacher { get; init; }
    public Student Student { get; init; }



    public Schedule(Teacher teacher, Student student)
    {
        Teacher = teacher;
        Student = student;

    }
}