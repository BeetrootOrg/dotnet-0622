using static System.Console;

namespace ConsoleApp.School;

class Pupil
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime DateOfBirth { get; init; }
    public string Sex { get; init; }
    public string Grade { get; init; }

    public Pupil(string firstName, string lastName, DateTime dateOfBirth, string sex, string grade)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Sex = sex;
        Grade = grade;
    }
}
