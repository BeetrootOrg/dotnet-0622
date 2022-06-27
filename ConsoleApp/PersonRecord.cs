namespace ConsoleApp;

record PersonRecord(string FirstName, string LastName, int Age = 42);

record PersonWithProperties
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private int Age { get; set; } = 42;
}