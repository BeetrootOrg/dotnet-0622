using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp.InternetShop
{
    internal class Product
    {
        private int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }

        public Product() { }
        public Product(string productName, int productCount)
        {
            ProductId = 1;
            ProductName = productName;
            ProductCount = productCount;
        }
        public Product(int productId, string productName,int productCount): this(productName,productCount)
        {
            ProductId = productId;
        }

        public Product(Product product)
        {
            ProductId = product.ProductId;
            ProductName = product.ProductName;
            ProductCount = product.ProductCount;
        }
        public int GetProductId() => ProductId;

        public override string ToString()
        {
            return $"Product ID: {ProductId.ToString()} | Product Name: {ProductName} | Product Count: {ProductCount.ToString()}";
        }

        public void ChangeProductCount(int quantity)
        {
            ProductCount -= quantity;
        }
    }

    interface ICreateProduct
    {
        public void CreateProductField(int productId, string productName, int productCount);
    }

    interface IProductSupply
    {
        public void ProductSupply(string productName, int quantity);
    }


    
}
