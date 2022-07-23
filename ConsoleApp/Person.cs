namespace ConsoleApp;

class Person
{
    public int Age { get; set; }
    public string Name { get; set; }

    void GetInfo()
    {
        System.Console.WriteLine($"Name:{Name}, Age:{Age}");
    }
}