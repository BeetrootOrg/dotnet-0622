using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Emloyee : IPerson
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Email { get; set; }

        public decimal Amount { get; set; }

        public TimeSpan Schedule { get; set; }

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

        private Storage _storage = new Storage();
        public ArrayList AddApplesToStorage(IGoods apples, int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                _storage.AppleStorage.Add(apples);
            }
            return _storage.AppleStorage;
        }

        public ArrayList AddVegetablesToStorage(IGoods vegetables, int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                _storage.VegetableStorage.Add(vegetables);
            }
            return _storage.VegetableStorage;
        }

        public ArrayList AddAlcoholToStorage(IGoods alcohol, int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                _storage.AlcoholStorage.Add(alcohol);
            }
            return _storage.AlcoholStorage;
        }

        public ArrayList AddNonAlcoholToStorage(IGoods nonalcohol, int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                _storage.NonAlcoholStorage.Add(nonalcohol);
            }
            return _storage.NonAlcoholStorage;
        }
        public ArrayList AddBakeryToStorage(IGoods bakery, int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                _storage.BakeryStorage.Add(bakery);
            }
            return _storage.BakeryStorage;
        }

        public void ViewStorage()
        {
            Console.WriteLine($"В ябулчному сховищі {_storage.AppleStorage.Count} яблук");
            Console.WriteLine($"В овочевому сховищі {_storage.VegetableStorage.Count} овочів");
            Console.WriteLine($"В алкогольному сховищі {_storage.AlcoholStorage.Count} пляшок алкоголю");
            Console.WriteLine($"В безалкогольному сховищі {_storage.NonAlcoholStorage.Count} пляшок");
        }

        public ArrayList AddToCart(IGoods goods)
        {
            Cart.Add(goods);

            return Cart;
        }

        public void GetCheck()
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
                if (Amount > item.Price)
                {
                    Console.WriteLine($"Товар {item.Name} Куплено!");
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
