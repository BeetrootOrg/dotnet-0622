using System;

using ConsoleApp;

using static System.Console;

var person = new Person("Dima", "Misik");

WriteLine(person.FirstName);
WriteLine(person.LastName);

var person1 = new Person("Dima", "Misik", 25);
var person2 = new Person("Dima", "Misik", 25);

// Compilation error
// WriteLine(person1.Age)

WriteLine(person1.YearOfBirth());
WriteLine(person1);
WriteLine(person1 == person2);
WriteLine(person1.Equals(person2));

var pr1 = new PersonRecord("Dima", "Misik", 25);
var pr2 = new PersonRecord("Dima", "Misik", 25);
WriteLine(pr1);
WriteLine(pr1 == pr2);
WriteLine(pr1.Equals(pr2));

var prp1 = new PersonWithProperties
{
    FirstName = "First",
    LastName = "Last",
};

var prp2 = new PersonWithProperties
{
    FirstName = "First",
    LastName = "Last",
};

WriteLine("EQUALITY");
WriteLine(prp1 == prp2);

prp2.FirstName = "F";
WriteLine(prp1 == prp2);

prp2.FirstName = "First";

if (prp1 == prp2)
{
    // do something very complex
    Method1(prp1);
    // continue next
}

void Method1(PersonWithProperties prp1)
{
    prp1.FirstName = "F";
}

try
{
    person.FirstName = null;
}
catch (ArgumentException)
{
    // ignore
}

try
{
    person.LastName = string.Empty;
}
catch (ArgumentException)
{
    // ignore
}

person.FirstName = "D";
person.LastName = "M";
person.FirstName = "V";

WriteLine($"Modified: {person.Modified}");

// Compilation error
// person.Modified = 42;

var singleton1 = Singleton.Instance;
var singleton2 = Singleton.Instance;
WriteLine("REF EQUALS");
WriteLine(ReferenceEquals(singleton1, singleton2));