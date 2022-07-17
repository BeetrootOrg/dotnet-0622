using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp.InternetShop
{
    internal class Receipt : IClientReceipt
    {
        private int ClientId { get; init; }
        private int ReceiptId { get; init; }
        public List<Product> ProductList { get; set; }

        public int GetReceiptId() => ReceiptId;

        public Receipt() { ProductList = new  List<Product>(); }
        public Receipt(int clientId) : this()
        {
            ClientId = clientId;
        }
        public Receipt(int clientId, int receiptId) : this(clientId)
        {
            ReceiptId = receiptId;
        }
        public Receipt(int clientId, int receiptId, Product product) : this(clientId,receiptId)
        {
            ProductList.Add(product);
        }
        public Receipt(Receipt receipt) : this()
        {
            ClientId = receipt.ClientId;
            ReceiptId = receipt.ReceiptId;
            foreach(Product product in receipt.ProductList)
            {
                ProductList.Add(product);
            }
        }
        public Receipt(Client client) : this()
        {
            Randomizer randomizer = new Randomizer();
            ClientId = client.GetClientId();
            ReceiptId = Int32.Parse(ClientId.ToString() + randomizer.Randomize(20));
            foreach (Product product in client.Receipt.ProductList)
            {
                ProductList.Add(product);
            }

        }

        public void ReceiptClear()
        {
            ProductList.Clear();
            Console.WriteLine("The Recipt list is cleared");
            Console.ReadKey();
        }
        public void PutInStash(Product product)
        {
            ProductList.Add(product);
        }

        public void ShowProductList()
        {

            foreach (Product product in ProductList)
            {
                Console.Write($"{product.ProductName} ");
            }
        }

        public string ProductListToString()
        {
            string result = string.Empty;
            foreach (Product product in ProductList)
            {
                result += product.ProductName + " - " + product.ProductCount + " ";
            }

            return result;
        }

        public override string ToString()
        {
            return $"Client ID: {ClientId.ToString()} | Receipt ID : {ReceiptId} | Product List : { ProductListToString() } ";
        }

    }


    interface IReceiptClear
    {
        public void ReceiptClear();
    }



}


