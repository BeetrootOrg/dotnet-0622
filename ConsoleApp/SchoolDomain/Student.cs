namespace ConsoleApp.SchoolDomain;

class Student
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private Level _level;

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
      public int Age
    {
        get => _age;
        set
        {
            if (IsPositive(value))
            {
                _age= value;
            }
            else
            {
                System.Console.WriteLine($"Age is not valid.");
            }

        }
    }
           public Level Level
    {
        get => _level;
        set => _level = value;
    }


    public Student(string firstName, string lastName, int age, Level level )
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Level = level;
     
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