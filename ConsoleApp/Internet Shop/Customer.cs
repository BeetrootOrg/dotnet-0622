using static System.Console;

namespace ConsoleApp.InternetShop;

class Customer : Person, IDiscount
{
    public Product[] WishList { get; set; }
    public int CustomerDiscount { get; set; }
    public int PhoneNumber { get; set; }
    public Customer(string firstName, string lastName, int customerDiscount, int phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        CustomerDiscount = customerDiscount;
        PhoneNumber = phoneNumber;
    }
    public override void ShowInfo()
    {
        WriteLine(@$"Full Name: {FirstName}, {LastName}
        Wish List: {WishList}
        Discount: {CustomerDiscount}
        Phone Number: {PhoneNumber}");
    }

    public decimal CalculateDiscount(int productPrice)
    {
        decimal amountOfDiscount = productPrice * CustomerDiscount / 100;
        return productPrice - amountOfDiscount;
    }
}