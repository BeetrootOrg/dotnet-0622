var person1 = new Person("Dima", "Misik", 25);
var person2 = new Person("Dima", "Misik", 25);
var person3 = new Person("A", "B", 42);
System.Console.WriteLine(person1.GetPerson());
System.Console.WriteLine(person1 == person2);
System.Console.WriteLine(person1.Equals(person2));
System.Console.WriteLine(person1.CompareTo(person2));
System.Console.WriteLine(person1.CompareTo(person3));

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
