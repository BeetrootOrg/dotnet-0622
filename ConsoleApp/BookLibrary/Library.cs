namespace ConsoleApp.BookLibrary;
class Library
{
    public string Name { get; init; }
    public string Address { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }

    public Library(string name, string address, string email, string phoneNumber)
    {
        Name = name;
        Address = address;
        Email = email;
        PhoneNumber = phoneNumber;
    }


}