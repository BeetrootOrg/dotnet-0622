namespace ConsoleApp.InternetShop;

class CustomerDatabase
{
    public List<Customer> CustomerList { get; set; } = new List<Customer>();

    public List<Customer> RegisterCustomer(Customer newCustomer)
    {
        CustomerList.Add(newCustomer);
        return CustomerList;
    }
}