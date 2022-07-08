using ConsoleApp.School;


Lesson firstLesson = new Lesson
{
Subject = "Math",
Time = "09:00"
};

Schedule firstGrade = Schedule.CreateSchedule(DayOfWeek.Monday, new Lesson[] {firstLesson}, 2);