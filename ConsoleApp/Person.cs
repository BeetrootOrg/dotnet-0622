using System;

namespace ConsoleApp;

class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public string FirstName
    {
        get => _firstName;
        set
        {
            ValidateNotEmptyOrNull(value);
            _firstName = value;
            ++Modified;
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            ValidateNotEmptyOrNull(value);
            _lastName = value;
            ++Modified;
        }
    }

    private int Age
    {
        get => _age;
        set
        {
            ValidatePositive(value);
            _age = value;
            ++Modified;
        }
    }

    public int Modified { get; private set; }

    public Person(string firstName, string lastName, int age = 42)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public int YearOfBirth() => DateTime.Now.AddYears(-Age).Year;

    private static void ValidatePositive(int value)
    {
        if (value <= 0)
        {
            throw new ArgumentException();
        }
    }

    private static void ValidateNotEmptyOrNull(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException();
        }
    }
}
