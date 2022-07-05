namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
           Customer Tolik = new Customer();
           Emloyee Jora = new Emloyee();

            Jora.AddApplesToStorage(new Apple(), 15);
            Jora.AddVegetablesToStorage(new Cucumber(),15);
            Jora.AddAlcoholToStorage(new JackDaniels(), 15);
            Jora.AddNonAlcoholToStorage(new Pepsi(), 15);
            Jora.AddBakeryToStorage(new Palyanitsya(), 15);
            Console.WriteLine();
            Jora.ViewStorage();
            Console.WriteLine();

            Tolik.Name = "Tolik";
            Tolik.SurName = "Zavzyatiy";
            Tolik.Email = "Tolik@Gmail.com";
            Tolik.Amount = 300;
            Jora.Name = "Jora";
            Jora.SurName = "Kornev";
            Jora.Email = "Jorakornev@Gmail.com";
            Jora.Amount = 10;
            Console.WriteLine(Tolik.Name);
            Console.WriteLine();
            Tolik.AddToCart(new JackDaniels());
            Tolik.AddToCart(new _777());
            Tolik.AddToCart(new Apple());
            Tolik.AddToCart(new Cucumber());
            Tolik.AddToCart(new Palyanitsya());
            Tolik.AddToCart(new Pepsi());

            Tolik.Buying(Tolik.Cart);

            Tolik.GetCheck();


            Console.WriteLine(Jora.Name);
            Console.WriteLine();
            Jora.AddToCart(new JackDaniels());
            Jora.AddToCart(new _777());
            Jora.AddToCart(new Apple());
            Jora.AddToCart(new Cucumber());
            Jora.AddToCart(new Palyanitsya());
            Jora.AddToCart(new Pepsi());

            Jora.Buying(Jora.Cart);

            Jora.GetCheck();



        }
    }
}