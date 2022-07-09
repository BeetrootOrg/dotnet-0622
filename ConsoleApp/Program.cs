using ConsoleApp.School;

public class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher(firstName: "Ivan", lastName: "Ivanovych",
            middleName: "Ivanov", age: 50, subject: Subject.Mathematics, classRoom: ClassRoom._101);

        Student student = new Student(firstName: "Vovochka", lastName: "Durachok", age: 6,
            classesAtSchool: Classes.FirstClass);
    }
}