namespace ConsoleApp.SchoolHW;

enum Lessons
{
    FirstLesson,
    SecondLesson,
    ThirdLesson,
    FourthLesson
}
class Schedule
{
    private const string _noLesson = "No Lesson";
    private string[] _lessons = {_noLesson, _noLesson, _noLesson, _noLesson};
    public string this[Lessons index]
    {
        get => index switch
        {
            Lessons.FirstLesson => _lessons[0],
            Lessons.SecondLesson => _lessons[1],
            Lessons.ThirdLesson => _lessons[2],
            Lessons.FourthLesson => _lessons[3]
        };
        private set { }
    }
    public string DayOfWeek { get; set; }

    public void AssignFirstLesson(string lessonName)
    {
        _lessons[0] = lessonName;
    }
    public void AssignSecondLesson(string lessonName)
    {
        _lessons[1] = lessonName;
    }
    public void AssignThirdLesson(string lessonName)
    {
        _lessons[2] = lessonName;
    }
    public void AssignFourthLesson(string lessonName)
    {
        _lessons[3] = lessonName;
    }
}