namespace ConsoleApp.InternetShop;
partial class Program
{
    static void Main()
    {
        var wardrobe1 = new Wardrobe(150, 1, 50);
        var table1 = new Table(100, 1, 90);
        var buyer1 = new Buyer
        {
            FirstName = "Jake",
            LastName = "Johnson",
            PersonalID = 4648392,
            PhoneNumber = 3527283,
            Email = "johnsonjake@gmail.com"
        };

        wardrobe1.AddQuantity();
        table1.AddQuantity();

    }

}