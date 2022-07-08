namespace ConsoleApp.SchoolHW;

class Student
{
    public string FullName { get; init; }
    public DateTime DateOfBirth { get; init; }
    public Schedule ScheduleForDay { get; set; }
}