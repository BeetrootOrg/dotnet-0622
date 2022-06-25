var person = new Person();
System.Console.WriteLine(person.GetPerson());

class Person
{
    string _firstName = "Placeholder for FN";
    string _lastName = "Placeholder for LN";
    int _age = 42;

    public string GetPerson()
    {
        return $"First Name: {_firstName}; Last Name: {_lastName}; Age: {_age}";
    }
}
