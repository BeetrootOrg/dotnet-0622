using static System.Console;
using System.Collections.Generic;
using ConsoleApp;


void Print<T>(IEnumerable<T> collection)
{

    WriteLine(string.Join(", ", collection));
}

Print(new[] { 1, 2, 3 });

var persons  = new List<Person>();
persons.Add(new Person
{
    FirstName = "Dima",
    LastName = "Misik",
    Heigth = 178, 
    Weigth = 70
});

persons.Add(new Person
{
    FirstName = "ваыв",
    LastName = "ыы",
    Heigth = 18,
    Weigth = 70
});

persons.Add(new Person
{
    FirstName = "Dimыыa",
    LastName = "Mффisik",
    Heigth = 178,
    Weigth = 7
});


Clear();
Print(persons);

WriteLine("Capacity =  " + persons.Capacity);
WriteLine("Count =  " + persons.Count);
var person = new Person
{
FirstName = "f",
LastName = "l"
};

var phoneBook  = new Dictionary<string, Person>();
phoneBook.Add("123213", person);
phoneBook.Add("1sdf13", new Person());
Print(phoneBook);


// Create a list of strings by using a
// collection initializer.
var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

// Remove an element from the list by specifying
// the object.
//salmons.Remove("coho");
salmons.Remove("pink");

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
    

}
Console.Write("");
// Output: chinook pink sockeye

