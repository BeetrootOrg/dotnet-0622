using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IPerson
    {
        string Name { get; }
        string SurName { get; }
        string Email { get; }
        decimal Amount { get; }


        public void Buying(ArrayList goods);

        public ArrayList AddToCart(IGoods goods);
    }
}
