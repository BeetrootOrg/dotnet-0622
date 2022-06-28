using ConsoleApp;



var pupil = new Pupil
{
    FirstName = "Mark",
    LastName = "Maksimovich",
    SchoolClass = "11B",
    DateBirth = new DateTime(2015, 12, 31)
};  

Console.WriteLine (pupil);
Console.WriteLine (pupil.FirstName);
Console.WriteLine (pupil.LastName);
Console.WriteLine (pupil.SchoolClass);
Console.WriteLine (pupil.DateBirth);

var teacher1 = new Teacher();