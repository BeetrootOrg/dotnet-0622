using ConsoleApp.PhoneBook.Common;

namespace ConsoleApp.PhoneBook;

class Person
{
    public Gender Gender { get; set; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
}