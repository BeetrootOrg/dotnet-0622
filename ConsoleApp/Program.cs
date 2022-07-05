namespace ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
           Customer Tolik = new Customer();
           Emloyee Jora = new Emloyee();

            Tolik.Name = "Tolik";
            Tolik.SurName = "Zavzyatiy";
            Tolik.Email = "Tolik@Gmail.com";
            Tolik.Amount = 300;
            Tolik.AddToCart(new JackDaniels());
            Tolik.AddToCart(new _777());
            Tolik.AddToCart(new Apple());
            Tolik.AddToCart(new Cucumber());
            Tolik.AddToCart(new Palyanitsya());
            Tolik.AddToCart(new Pepsi());

            Tolik.Buying(Tolik.Cart);

            Tolik.GetCheck();

            Jora.Name = "Jora";
            Jora.SurName = "Kornev";
            Jora.Email = "Jorakornev@Gmail.com";
            Jora.Amount = 10;
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