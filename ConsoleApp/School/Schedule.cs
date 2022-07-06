namespace School;

class Schedule
{
    public string[][] Lessons {get;set;}
    public string[] GetScheduleForDay(string day) // DateTime.Now.DayOfWeek.ToString()
    {
        switch (day)
        {
            case ("Monday"):
                return Lessons[0];
                break;
            case ("Tuesday"):
                return Lessons[1];
                break;
            case ("Wednesday"):
                return Lessons[2];
                break;
            case ("Thursday"):
                return Lessons[3];
                break;
            case ("Friday"):
                return Lessons[4];
                break;
            default:
                return new string[] {"Day off"};
                break;
        }
    }
}