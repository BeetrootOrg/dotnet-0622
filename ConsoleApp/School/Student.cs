namespace ConsoleApp.School;


public class Student : Person
{
    public Student(string firstName, string lastname, byte age, Classes classesAtSchool)
    {
        firstName = FirstName;
        lastname = LastName;
        age = Age;
        classesAtSchool = ClassesAtSchool;
    }
    
    public Classes ClassesAtSchool { get; set; }

    public string GetNameStudent () => $"First Name = {FirstName};Last Name = {LastName}; Age = {Age}; ClassesAtSchool = {ClassesAtSchool}";
}
