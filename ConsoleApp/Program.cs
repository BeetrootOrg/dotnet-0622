using System;
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

WriteLine(persons[1]);
persons[4] = new Person
{
    FirstName = "fff",
    LastName = "1234"
};

persons.Clear();
WriteLine("AFTER CLEAR");
WriteLine($"Capacity = {persons.Capacity}");
WriteLine($"Count = {persons.Count}");

var person = new Person
{
    FirstName = "f",
    LastName = "l"
};

persons.AddRange(new[]
{
    person,
    new Person
    {
        FirstName = "F",
        LastName = "L"
    }
});

WriteLine(persons.Contains(person));
WriteLine(persons.Contains(new Person
{
    FirstName = "f",
    LastName = "l"
}));
WriteLine(persons.Contains(new Person
{
    FirstName = "f",
    LastName = "l",
    Weight = 1
}));

var arr1 = Array.Empty<Person>();
var arr2 = new Person[1];
var arr3 = new Person[2];
var arr4 = new Person[3];

// persons.CopyTo(arr1);
// persons.CopyTo(arr2);
persons.CopyTo(arr3);
persons.CopyTo(arr4);

Print(arr1);
Print(arr2);
Print(arr3);
Print(arr4);

var phoneBook = new Dictionary<string, Person>();

phoneBook.Add("+12345", person);
phoneBook.Add("+2467", new Person());
Print(phoneBook);

// Exception below cause element already added
// phoneBook.Add("+2467", new Person
// {
//     FirstName = "A",
//     LastName = "B",
//     Height = 123,
//     Weight = 12
// });

var result = phoneBook.TryAdd("+2467", new Person
{
    FirstName = "A",
    LastName = "B",
    Height = 123,
    Weight = 12
});

WriteLine($"TryAdd = {result}");

phoneBook["+2467"] = new Person
{
    FirstName = "A",
    LastName = "B",
    Height = 123,
    Weight = 12
};

Print(phoneBook);

persons = new List<Person>
{
    person,
    new Person
    {
        FirstName = "ABC"
    }
};

phoneBook = new Dictionary<string, Person>
{
    { "+123", person },
};

phoneBook = new Dictionary<string, Person>
{
    ["+123"] = person
};

Print(persons);
Print(phoneBook);

var set = new HashSet<Product>
{
    new Product
    {
        Name = "caroot",
        Price = 10
    },
    new Product
    {
        Name = "potato",
        Price = 15
    }
};

set.Add(new Product
{
    Name = "caroot",
    Price = 10
});

Print(set);

var set1 = new HashSet<int>();
set1.Add(1);
set1.Add(2);
set1.Add(1);
set1.Add(3);
Print(set1);

set1.ExceptWith(new[] { 2 });
WriteLine("AFTER ExceptWith");
Print(set1);

set1.IntersectWith(new[] { 1 });
WriteLine("AFTER IntersectWith");
Print(set1);