using System.Collections.Generic;

using ConsoleApp;

using static System.Console;

void Print<T>(IEnumerable<T> collection)
{
    WriteLine(string.Join(", ", collection));
}

Print(new[] { 1, 2, 3 });

var persons = new List<Person>();
persons.Add(new Person
{
    FirstName = "Dima",
    Height = 178,
    LastName = "Misik",
    Weight = 70
});

Print(persons);