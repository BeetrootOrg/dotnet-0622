using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.InternetShop
{
    class Table : IWarehouse
    {
        private List<Client> ClientList { get; set; }
        public List<Product> ProductList { get; set; }
        private List<Receipt> ReceiptList { get; set; }

        public Table()
        {
            ClientList = new List<Client>();
            ProductList = new List<Product>();
            ReceiptList = new List<Receipt>();
        }


        public void AddClientToList(Client client)
        {
            Client newClient = new Client(client);
            ClientList.Add(newClient);
        }
        public void AddReceiptToList(Receipt receipt)
        {
            Receipt newReceipt = new Receipt(receipt);
            ReceiptList.Add(newReceipt);
        }
        public void AddProductToList(Product product)
        {
            Product newProduct = new Product(product);
            ProductList.Add(product);
        }
        public Client FindClient(string firstName, string lastName)
        {
            foreach (Client client in ClientList)
            {
                if (client.FirstName.ToLower() == firstName.ToLower() && client.LastName.ToLower() == lastName.ToLower())
                {
                    return new Client(client.GetClientId(), firstName, lastName);
                }
            }
            return null;

        }
        public Product FindProduct(string productName)
        {
            foreach (Product product in ProductList)
            {
                if (product.ProductName.ToLower() == productName.ToLower())
                {
                    return product;
                }
            }
            return null;
        }
        public void CreateProductField(int productId, string productName, int productCount)
        {
            
            Product product = new Product(productId, productName, productCount);
            ProductList.Add(product);
        }

        public void ProductSupply(string productName, int quantity)
        {
            Product product = FindProduct(productName);
            product.ProductCount += quantity;
        }
        public void BorderDraw<T>(T obj)
        {
            for (int i = 0; i < obj.ToString().Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public void TablePrint<T>(T obj)
        {

            BorderDraw<T>(obj);
            Console.WriteLine(obj.ToString());
            BorderDraw<T>(obj);
        }

        public void ShowTables()
        {
            Console.Clear();
            Console.WriteLine("Tables To Show: 1 - Clients, 2 - Products, 3 - Receipts");
            var option = Console.ReadKey();
            switch (option.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Clear();
                        foreach (Client i in ClientList)
                        {
                            TablePrint(i);
                        }
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Console.Clear();
                        foreach (Product i in ProductList)
                        {
                            TablePrint(i);
                        }
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Console.Clear();
                        foreach (Receipt i in ReceiptList)
                        {
                            TablePrint(i);
                        }
                        break;
                    }
            }
            Console.ReadKey();
        }

    }

    interface IWarehouse : ICreateProduct, IProductSupply
    {
        public void CreateProductField(int productId, string productName, int productCount);
        public void ProductSupply(string productName, int quantity);

    }

}