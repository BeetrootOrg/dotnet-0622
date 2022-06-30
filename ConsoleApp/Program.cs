using ConsoleApp;
using static System.Console;



var pupil = new Pupil
{
    FirstName = "Mark",
    LastName = "Maksimovich",
    SchoolClass = SchoolClass.B10,
    DateBirth = new DateTime(2015, 12, 31)
};  

Teacher teacher1 = new Teacher 
{
    FirstName = "Klara",
    LastName = "Ericsson",
    Subject = Subject.Chemestry
};

Person somePerson = new Person
{
    FirstName = "ivan",
    LastName = "ivanov",
    DateBirth = new DateTime(2035, 11, 12)
};

Console.WriteLine (pupil);
Console.WriteLine (pupil.FirstName);
Console.WriteLine (pupil.LastName);
Console.WriteLine (pupil.SchoolClass);
Console.WriteLine (pupil.DateBirth);

Console.WriteLine (teacher1.FirstName);
Console.WriteLine (teacher1.LastName);

WriteLine(somePerson.GetPerson());
WriteLine(pupil.GetPerson());
WriteLine(teacher1.GetPerson());

var lesson1 = new Lesson(SchoolClass.A11, ClassRoom._16, teacher1, new DateTime(2022,07, 02, 10, 0, 0));

WriteLine (lesson1);


