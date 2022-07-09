
namespace ConsoleApp.SchoolDomain;
public enum Subject
{
   English ,
   Chemistry,
   Math,
   PE,
   Geography,
   Arts,
   History
}

class Teacher
{
    private string _firstName;
    private string _lastName;
    private Subject _primarySubject;
    private int _salary;

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (IsNotEmpty(value))
            {
                _firstName = value;
            }
            else
            {
                System.Console.WriteLine($"First Name is empty.");
            }
        }
    }
    public string LastName
    {
        get => _lastName;
        set
        {
            if (IsNotEmpty(value))
            {
                _lastName = value;
            }
            else
            {
                System.Console.WriteLine($"Last Name is empty.");
            }
        }
    }
    public int Salary
    {
        get => _salary;
        set
        {
            if (IsPositive(value))
            {
                _salary = value;
            }
            else
            {
                System.Console.WriteLine($"Salary is not appropriate.");
            }

        }
    }
         public Subject PrimarySubject
    {
        get => _primarySubject;
        set => _primarySubject = value;
    }

    public Teacher(string firstName, string lastName, Subject subject, int salary)
    {
        _firstName = firstName;
        _lastName = lastName;
        _primarySubject = subject;
        _salary = salary;
    }
    private bool IsPositive(int value)
    {
        if (value > 0) return true;
        else return false;
    }
    private bool IsNotEmpty(string value)
    {
        if (value != null && value.Length != 0) return true;
        else return false;
    }
}