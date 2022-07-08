namespace ConsoleApp.School;

class Schedule
{
    public DayOfWeek SchoolDay { get; init; }
    public Lesson[] Lessons { get; init; }
    public int Classroom { get; init; }

    public static Schedule CreateSchedule(DayOfWeek schoolDay, Lesson[] lessons, int classroom)
    {
        Schedule toReturn = new Schedule
        {
            SchoolDay = schoolDay,
            Lessons = lessons,
            Classroom = classroom
        };
        return toReturn;
    }
}

