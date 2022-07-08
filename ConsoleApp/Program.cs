using ConsoleApp.School;

public class Program
{
    private static void Main(string[] args)
    {
        var teacher = new Teacher(firstName: "Ivan", lastName: "Ivanovych",
        middleName: "Ivanov", age: 50, subject: Subject.Mathematics, classRoom: ClassRoom._101);
        System.Console.WriteLine(teacher.GetNameTeacher());

        var student = new Student(firstName: "Vovochka", lastname: "Durachok", age: 6, classesAtSchool: Classes.FirstClass);
        System.Console.WriteLine(student.GetNameStudent());
    }
}