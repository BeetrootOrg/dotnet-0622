namespace ConsoleApp.Shop;
using System;
using System.Collections.Generic;

class Shop : IBuyGoods, IGetCatalog
{
    private Dictionary<Cart, Buyer> _carts { get; set; }
    public void BuyGoods(Goods goods, int amount)
    {
        throw new NotImplementedException();
    }
    public Group GetCatalog()
    {
        throw new NotImplementedException();
    }
}