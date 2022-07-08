namespace ConsoleApp.Scool;

class Lesson
{
    public Teacher TeacherOnLesson { get; set; }
    public Student StudentOnLesson { get; set; }
    public int LessonId { get; set; }
    private DateTime DateOfLesson { get; set; }
}
