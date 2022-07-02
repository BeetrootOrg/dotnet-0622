namespace ConsoleApp.Library;

class AccountingBook
{
public bool IsInStock {get; set; }
public Book OurBook {get; init; }
public Person Client {get; init; }
}