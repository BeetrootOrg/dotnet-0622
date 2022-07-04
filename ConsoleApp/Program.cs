using ConsoleApp.InternetShop;

var client1 = new Buyer { FirstName = "Tom", LastName = "Jobs", NumberPhone = "+38900099999" };

var prod1 = new Product { ProductName = "Lenovo Legion 5", ProductType = ProductType.LaptopsAndComputers, ProductPrice = 1500, Quantity = 5 };
var prod2 = new Product { ProductName = "iPhone 4s", ProductType = ProductType.Smartphones, ProductPrice = 400, Quantity = 1 };

var receipt1 = new[]
{
    new Receipt
    {
        BuyerID = client1.NumberPhone,
        ProductList = new []{prod1,prod2},
        TimePurchase = DateTime.Now
    }
};