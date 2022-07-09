namespace ConsoleApp.AutoService;

class Human
{
    public string Name { get; init; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    virtual public string Say() => "Hello, there";
}