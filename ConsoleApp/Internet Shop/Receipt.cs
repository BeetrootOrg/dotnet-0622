namespace ConsoleApp.InternetShop;

class Receipt
{
    public Employee Cashier { get; set; }
    public Customer Buyer { get; set; }
    public List<Product> SoldProducts { get; set; }
    public DateTime DateOfPurchase { get; set; }
    public decimal SumOfPurchase
    {
        get
        {
            decimal sumOfPurchase = 0;
            for (int i = 0; i < SoldProducts.Count; i++)
            {
                sumOfPurchase += SoldProducts[i].Price;
            }
            return sumOfPurchase;
        }
    }

    public Receipt(Employee cashier, Customer buyer, List<Product> soldProducts)
    {
        Cashier = cashier;
        Buyer = buyer;
        SoldProducts = soldProducts;
        DateOfPurchase = DateTime.Today;
    }

}