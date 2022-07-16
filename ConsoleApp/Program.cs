using ConsoleApp.Shop;

using System;

public class Program
{
    private static void Main(string[] args)
    {
        var good1 = new Goods
        {
            Price = 123,
            Name = "Alcochol"
        };
        var good2 = new Goods
        {
            Price = 50,
            Name = "Eat"
        };
        var cart = new Cart();
        cart.AddItem(good1);
        cart.AddItem(good2);
        
    }
}