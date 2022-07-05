using System;
using static System.Console;
using ConsoleApp;

class Program 
{
    public static void Main() 
    {
    
        var badmintonRacketsCategory = new ProductCategory
        {
            CategoryName = "Badminton rackets",
            ProductSuffix = "Badminton Racket"
        };


        var product1 = new Product
        {
            SKU = "AX100ZZ",
            Name = "Astrox 100ZZ",
            ProductCategory = badmintonRacketsCategory,
            Price = 140
        };

        var product2 = new Product
        {
            SKU = "AX99P",
            Name = "Astrox 99 Pro",
            ProductCategory = badmintonRacketsCategory,
            Price = 120
        };
    
    var cart = new Cart();

    cart.AddToCart(product1);
    cart.AddToCart(product2);
    cart.ShowCart();

    }
}