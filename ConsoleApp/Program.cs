using ConsoleApp.SchoolHW;
internal class Program
{
    private static void Main(string[] args)
    {
        Room classRoom = new Room
        {
            RoomNumber = 209,
            RoomType = "Classroom"
        };
        Room serviceRoom = new Room
        {
            RoomNumber = 315,
            RoomType = "Service Room"
        };

        Employee teacher = new Employee(200, "Tikhon Lavrov", "Teacher");
        Employee cleaner = new Employee(100, "Nimra Talbot", "Cleaner");

        Schedule mondaySchedule = new Schedule
        {
            DayOfWeek = "Monday"
        };
        mondaySchedule.AssignFirstLesson("Math");
        mondaySchedule.AssignFourthLesson("English");
        mondaySchedule.AssignThirdLesson("PE");
        Schedule fridaySchedule = new Schedule
        {
            DayOfWeek = "Friday"
        };
        fridaySchedule.AssignFirstLesson("Computer Science");
        fridaySchedule.AssignSecondLesson("Biology");
        fridaySchedule.AssignFourthLesson("Chemistry");

        Student teresaCunningham = new Student
        {
            DateOfBirth = new DateTime(2000, 12, 31),
            FullName = "Teresa Cunningham",
            ScheduleForDay = mondaySchedule
        };
        Student jaspalValdez = new Student
        {
            DateOfBirth = new DateTime(2002, 9, 18),
            FullName = "Jaspal Valdez",
            ScheduleForDay = fridaySchedule
        };

        School testSchool = new School
        {
            SchoolName = "Test Name",
            SchoolRooms = new[] {classRoom, serviceRoom},
            SchoolStudents = new[] {teresaCunningham, jaspalValdez},
            SchoolWorkers = new[] {teacher, cleaner}
        };
    }
}