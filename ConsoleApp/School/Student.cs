namespace ConsoleApp.School;


public class Student : Person
{
    public Student(string firstName, string lastName, byte age, Classes classesAtSchool)
    {

        firstName = FirstName;
        lastName = LastName;
        age = Age;
        classesAtSchool = ClassesAtSchool;
    }
    public Classes ClassesAtSchool { get; set; }
}
