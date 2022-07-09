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
WriteLine($"Capacity = {persons.Capacity}");
WriteLine($"Count = {persons.Count}");

persons.Add(new Person
{
    FirstName = "D",
    Height = 179,
    LastName = "M",
    Weight = 50
});

persons.Add(new Person
{
    FirstName = "A",
    Height = 200,
    LastName = "B",
    Weight = 100
});

persons.Add(new Person
{
    FirstName = "asdjksadkls",
    Height = 200,
    LastName = "KKKK",
    Weight = 100
});

persons.Add(new Person
{
    FirstName = "123",
    Height = 1,
    LastName = "fff",
    Weight = 100.5
});

WriteLine($"Capacity = {persons.Capacity}");
WriteLine($"Count = {persons.Count}");