using ConsoleApp;

using static System.Console;

var person = new Person
{
    FirstName = "Dima",
    LastName = "Misik"
};

WriteLine(person.FirstName);
WriteLine(person.LastName);

var person1 = new Person(25)
{
    FirstName = "Dima",
    LastName = "Misik"
};

// Compilation error
// WriteLine(person1.Age)

WriteLine(person1.YearOfBirth());