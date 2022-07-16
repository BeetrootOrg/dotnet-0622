namespace ConsoleApp.Shop;
using System;
using System.Collections.Generic;

public class Cart
{
    public List<Goods> Goods { get; set; }
    public Cart()
    {
        Goods = new List<Goods>();
    }

    public void AddItem(Goods goods)
    {
        Goods.Add(goods);
        Console.WriteLine($"{goods.Name} added to cart with price: {goods.Price}");
    }
}