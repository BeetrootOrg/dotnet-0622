using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IGoods
    {
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
        DateTime MadeDate { get; }
        DateTime ExpirationDate { get; }
    }
}
