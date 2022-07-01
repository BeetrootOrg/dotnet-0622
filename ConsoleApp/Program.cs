namespace ConsoleApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Car opel = new Opel ();
            Car lexus = new Lexus ();
            Car porsche = new Porsche ();

            Customer customer = new Customer();

            customer.Drive(opel);
            Console.WriteLine();
            customer.Drive(porsche);
            Console.WriteLine();
            customer.Drive(lexus);
            Console.WriteLine();
            customer.Drive(new ZAZ());

        }
    }
}


