using System;
using System.Collections.Generic;
namespace ConsoleApp.Shop;

class Shop : IBuyGoods, IGetCatalog
{
    private Dictionary<Cart, Buyer> Carts { get; set; }
    public void BuyGoods(Goods goods, int amount)
    {
        throw new NotImplementedException();
    }
    public Group GetCatalog()
    {
        throw new NotImplementedException();
    }
}