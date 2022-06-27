namespace ConsoleApp.Library;

class Visitor
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public Book[] Books { get; set; }
    public DateTime BirthDate { get; init; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}