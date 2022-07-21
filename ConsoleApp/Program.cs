
Print(new[] { 1, 23, 4 });

void Print<T>(IEnumerable<T> collections)
{
    System.Console.WriteLine(string.Join('|', collections));
}


var persons = new List<Person<string>>();
persons.Add(new Person<string>
{
    Name = "Tom",
    Age = 42
});

class Person<T>
{
    public T Name { get; set; }
    public int Age { get; set; }
    
}