using System;

namespace ConsoleApp;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private int Age { get; set; } = 42;

    public Person()
    {
    }

    public Person(int age)
    {
        Age = age;
    }

    public int YearOfBirth() => DateTime.Now.AddYears(-Age).Year;
}
