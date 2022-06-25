using System;

var person1 = new Person("Dima", "Misik", 25);
var person2 = new Person("Dima", "Misik", 25);
var person3 = new Person("A", "B", 42);
System.Console.WriteLine(person1.GetPerson());
System.Console.WriteLine(person1 == person2);
System.Console.WriteLine(person1.Equals(person2));
System.Console.WriteLine(person1.CompareTo(person2));
System.Console.WriteLine(person1.CompareTo(person3));

var person4 = new PropertiesPerson
{
    FirstName = "Dima",
    LastName = "Misik",
    Age = 25
};

var person5 = new UnderTheHoodPropertiesPerson();
person5.SetFirstName("Dima");
System.Console.WriteLine(person5.GetFirstName());

System.Console.WriteLine(person4.GetPerson());

var person6 = new PropertiesWithBirthDatePerson
{
    FirstName = "Dima",
    LastName = "Misik",
    BirthDate = new DateTime(1996, 07, 11)
};

System.Console.WriteLine(person6.Age);

// Compilation error
// person1._firstName;

class Person
{
    string _firstName = "Placeholder for FN";
    string _lastName = "Placeholder for LN";
    int _age = 42;

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public string GetPerson()
    {
        return $"First Name: {_firstName}; Last Name: {_lastName}; Age: {_age}";
    }

    public bool CompareTo(Person person)
    {
        return _firstName == person._firstName &&
            _lastName == person._lastName &&
            _age == person._age;
    }
}

class PropertiesPerson
{
    public string FirstName { get; set; } = "Placeholder for FN";
    public string LastName { get; set; } = "Placeholder for LN";
    public int Age { get; set; } = 42;

    public string GetPerson()
    {
        return $"First Name: {FirstName}; Last Name: {LastName}; Age: {Age}";
    }
}

class PropertiesWithBirthDatePerson
{
    public string FirstName { get; set; } = "Placeholder for FN";
    public string LastName { get; set; } = "Placeholder for LN";
    public int Age
    {
        get
        {
            return (new DateTime() + (DateTime.Now - BirthDate)).Year - 1;
        }
    }
    // the same as above
    public int Age1 => (new DateTime() + (DateTime.Now - BirthDate)).Year - 1;
    public DateTime BirthDate { get; set; }

    public string GetPerson()
    {
        return $"First Name: {FirstName}; Last Name: {LastName}; Age: {Age}";
    }
}

class UnderTheHoodPropertiesPerson
{
    private string _firstName;

    public string GetFirstName() => _firstName;
    public void SetFirstName(string value) => _firstName = value;
}