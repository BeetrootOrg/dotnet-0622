using ConsoleApp;
using System;

var someCustomer = new Customer();

Product product1 = new Product
{
    Name = "Swatch",
    Description = "Quartz",
    Price = 150
};

Product product2 = new Product
{
    Name = "Rolex",
    Description = "Automatic",
    Price = 15000
};

Product product3 = new Product
{
    Name = "Citizen",
    Description = "Solar",
    Price = 250
};

Console.WriteLine("_____Welcome to the shop! :D_____");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Please enter your First Name:");
var firtName = Console.ReadLine();
if (string.IsNullOrEmpty(firtName))
{
    Console.Clear();
    Console.WriteLine("Buuu :(");
}
else 
{
    someCustomer.FirstName = firtName;
}

Console.WriteLine("Please enter your Last Name:");
var lastName = Console.ReadLine();
if (string.IsNullOrEmpty(lastName))
{
    Console.Clear();
    Console.WriteLine("Buuu :(");
}
else
{
    someCustomer.LastName = lastName;
}

Console.WriteLine("Please enter your Age:");
int age = Int32.Parse(Console.ReadLine());
if (age == 42)
{
    someCustomer.Age = age;
    someCustomer.IsPremium = true;
    product1.Price = 75;
    product2.Price = 13000;
    product3.Price = 199;
}
else
{
    someCustomer.Age = age;
    someCustomer.IsPremium = false;
}

Console.Clear();
Console.WriteLine("Thank you for the account information! :)");

    Console.WriteLine("Shop Menu:");
    Console.WriteLine("\t1 - Show all products");
    Console.WriteLine("\t2 - Enter cart");
    Console.WriteLine("\t0 - Exit");

    var key = Console.ReadKey();

    switch (key.Key)
    {
        case ConsoleKey.D0:
            Environment.Exit(0);
            break;
        case ConsoleKey.D1:
            Console.Clear();
            Product.ListProduct(product1);
            Product.ListProduct(product2);
            Product.ListProduct(product3);
            Console.WriteLine("Please add products to the cart by entering their numbers 1, 2 or 3");
            var myCart = new Cart();
            var productsSelected = Console.ReadLine();
            if (string.IsNullOrEmpty(productsSelected))
            {
                Console.Clear();
                Console.WriteLine("Brrrr!");
            }
            for (var i = 0; i < productsSelected.Length; i++)
            {
                if (productsSelected[i] == '1')
                {
                    myCart.AddToCart(product1);
                }
                if (productsSelected[i] == '2')
                {
                    myCart.AddToCart(product2);
                }
                if (productsSelected[i] == '3')
                {
                    myCart.AddToCart(product3);
                }
            }
            myCart.PrintCart();
            break;
        case ConsoleKey.D2:
            var myCart1 = new Cart();
            myCart1.PrintCart();
            break;
        default:
            break;
    }




