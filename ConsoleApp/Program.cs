using ConsoleApp.InternetShop;
Table dataBase = new Table();
Randomizer randomizer = new Randomizer();

Menu();


void Menu()
{
    while (true)
    {
        DrawMenuOptions();

        var option = Console.ReadKey();

        switch (option.Key)
        {

            //Client Register
            case ConsoleKey.D1:
                {
                    ClientRegister();
                    break;
                }
            //Product Add
            case ConsoleKey.D2:
                {
                    ProductCreation();
                    break;
                }
            //Product Supply
            case ConsoleKey.D3:
                {
                    ProductSupply();
                    break;
                }
            //Show the Tables we have
            case ConsoleKey.D4:
                {
                    dataBase?.ShowTables();
                    break;
                }
            case ConsoleKey.D5:
                {
                    Buying();
                    break;
                }
            case ConsoleKey.D6:
                {

                    return;
                }
        }
    }
}

void DrawMenuOptions()
{
    Console.Clear();
    Console.WriteLine("1: Client Register");
    Console.WriteLine("2: Add Product");
    Console.WriteLine("3: Product Supply");
    Console.WriteLine("4: Show Tables");
    Console.WriteLine("5: Buy");
    Console.WriteLine("6: Exit");
}
void ClientRegister()
{
    Console.Clear();
    Console.WriteLine("Input First Name: ");
    var firstName = Console.ReadLine();
    Console.WriteLine("Input Last Name: ");
    var lastName = Console.ReadLine();
    Console.WriteLine("Input email: ");
    var email = Console.ReadLine();
    Console.WriteLine("Input User Name: ");
    var userName = Console.ReadLine();
    Console.WriteLine("Input Phone Number");
    var phoneNumber = Console.ReadLine();


    Client client = new Client(Int32.Parse(randomizer.Randomize(20)), firstName, lastName, email, userName, phoneNumber);
    if(client == null)
    {
        PressAnyKeyToProcced("Incorrect Input");
        return;
    }
    dataBase.AddClientToList(client);
    PressAnyKeyToProcced("The client is Registered!");

}

void ProductCreation()
{
    Console.Clear();
    Console.WriteLine("Input Product Name");
    var productName = Console.ReadLine();
    Console.WriteLine("Input Product Count");
    int productCount;
    if(productName.Length == 0)
    {
        PressAnyKeyToProcced("Incorrect Input");
        return;
    }
    Int32.TryParse(Console.ReadLine(), out productCount);
    if (productCount <= 0)
    {
        PressAnyKeyToProcced("Incorrect Input");
        return;
    }
    dataBase?.CreateProductField(Int32.Parse(randomizer.Randomize(20)), productName, productCount);
}

void ProductSupply()
{
    Console.Clear();
    Console.WriteLine("Input Product Name that Supplied");
    var productName = Console.ReadLine();
    Console.WriteLine("Input Product Count that supplied");
    int productCount;
    Int32.TryParse(Console.ReadLine(), out productCount);
    if (productCount <= 0)
    {
        PressAnyKeyToProcced("Incorrect Input");
        return;
    }
    dataBase?.ProductSupply(productName,productCount);
}

//Find the client by it`s first and last name, then we find the product this client buy
//and then we create this client Reciept and store the product list in there
void Buying()
{

    Console.Clear();
    Console.WriteLine("Input First Name: ");
    var firstName = Console.ReadLine();

    Console.WriteLine("Input Last Name: ");
    var lastName = Console.ReadLine();

    Client client = dataBase.FindClient(firstName, lastName);
    if (client == null)
    {
        PressAnyKeyToProcced($"Didn`t find Client: {firstName} {lastName}");
        return;
    }
    Receipt receipt = new Receipt(client);

    while (true)
    {

        Console.WriteLine("Input Product that you buing");
        var productName = Console.ReadLine();

        Console.Write("Input quantity of product: ");
        int quantity;
        Int32.TryParse(Console.ReadLine(), out quantity);
        Product product = dataBase.FindProduct(productName);
        Product productInStash = new Product(product);
        if (productInStash == null)
        {
            PressAnyKeyToProcced($"Didn`t find Product: {productInStash.ProductName}");
            continue;
        }

        if (productInStash.ProductCount < quantity)
        {
            PressAnyKeyToProcced("Sorry, We don`t have this product in that quantity");
            continue;

        }

        productInStash.ProductCount = quantity;
        client.Receipt.PutInStash(productInStash);
        receipt.PutInStash(productInStash);
        Console.WriteLine("The Product is added to stash");

        Console.WriteLine("Proceed with buying");
        Console.WriteLine("1: Choose another product, 2: That`s all. Let`s buy it!  3: Clear receipt, 4: Clear and Exit");

        var option = Console.ReadKey();
        switch (option.Key)
        {
            case ConsoleKey.D1:
                {
                    continue;
                }
            case ConsoleKey.D2:
                {
                    var counter = 0;
                    Console.WriteLine("You successfully bought!");


                    dataBase.AddReceiptToList(receipt);

                    foreach (var i in client.Receipt.ProductList)
                    {
                        dataBase.ProductSupply(product.ProductName, (quantity*-1));

                        counter++;
                    }
                    
                    client.Receipt.ReceiptClear();
                    return;
                }
            case ConsoleKey.D3:
                {
                    client.Receipt.ReceiptClear();
                    break;
                }
            case ConsoleKey.D4:
                {
                    client.Receipt.ReceiptClear();
                    return;
                }
        }
    }
}


void PressAnyKeyToProcced(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Press any key to procced");
    Console.ReadKey();
}







