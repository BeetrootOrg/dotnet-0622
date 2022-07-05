using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Customer : IPerson
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }

        private ArrayList _cart = new ArrayList();
        public ArrayList Cart
        {
            get { return _cart; }
        }

        private ArrayList _check = new ArrayList();
        public ArrayList Check
        {
            get { return _check; }
        }


        public ArrayList AddToCart(IGoods goods)
        {
            Cart.Add(goods);

            return Cart;
        }

        public void GetCheck ()
        { 
            
            foreach (IGoods item in Check)
            {
                Console.WriteLine($"Товар {item.Name}, ціна {item.Price}");
                Console.WriteLine();
            }
        }

        public void Buying(ArrayList goods)
        {
            foreach (IGoods item in goods)
            {
                if (Amount>item.Price)
                {
                    Console.WriteLine ($"Товар {item.Name} Куплено!");
                    Console.WriteLine();
                    Amount -= item.Price;
                    Check.Add(item);
                }
                else
                    Console.WriteLine($"Товар {item.Name} не Куплено!, не вистачає грошей");
                Console.WriteLine();
            }
        }
    }

}
