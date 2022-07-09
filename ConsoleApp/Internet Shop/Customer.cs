using static System.Console;

namespace ConsoleApp.InternetShop;

class Customer : Person, IDiscount, IRegister
{
    public Product[] WishList { get; set; }
    public int CustomerDiscount { get; set; }
    public int PhoneNumber { get; set; }

    public override void GetInfo()
    {
        WriteLine(@$"Full Name: {FirstName}, {LastName}
        Wish List: {WishList}
        Discount: {CustomerDiscount}
        Phone Number: {PhoneNumber}");
    }

    public void Register()
    {
        throw new NotImplementedException(); // register new customer
    }

    public int SetDiscount()
    {
        throw new NotImplementedException(); // Personal customer's discount
    }


}