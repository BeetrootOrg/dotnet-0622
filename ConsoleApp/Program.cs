using System.IO;
using System.Text;

const string filePath = "baseContacts.csv";

void ExitProg()
{
    Environment.Exit(0);
};

string Serialize((string firstName, string lastName, string phone) row) => $"{row.firstName},{row.lastName},{row.phone}";

void ShowAllContacts()
{
    Console.Clear();
    try
    {
        var lines = ReadContacts(filePath);


        ShowRow(("First Name", "Last Name", "Phone"));
        foreach (var contact in lines)
        {
            ShowRow(contact);
        }

        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    catch (FileNotFoundException fnfe)
    {
        System.Console.WriteLine($"File not found {fnfe.Message}");
        Console.ReadKey();
    }
}

    void AddNewContacts()
    {
        Console.Clear();

        System.Console.Write("Enter first name: ");
        var firstName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(firstName)) { CheckCorrectInput(firstName, "incorrect name output"); }
        System.Console.Write("Enter second name: ");
        var lastName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(lastName)) { CheckCorrectInput(lastName, "incorrect last name output"); }
        System.Console.Write("Enter phone: +");
        var phone = Console.ReadLine();
        if (!int.TryParse(phone, out int value)) { throw new ArgumentException("the phone should contain only numbers", nameof(value)); }
        File.AppendAllLines(filePath, new[] { Serialize((firstName, lastName, phone)) });
    }

    void CheckCorrectInput(string value, string errorText = null)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(errorText, nameof(value));
        }
    }

    void ShowRow((string, string, string) row)
    {
        var (firstName, lastName, phone) = row;
        System.Console.WriteLine("{0,-15} {1,-15} {2,-15}", firstName, lastName, phone);
    }

    (string, string, string)[] ReadContacts(string file)
    {
        try
        {
            var lines = File.ReadAllLines(file);
            var contacts = new (string, string, string)[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                var items = lines[i].Split(',');
                try
                {
                    contacts[i] = (items[0], items[1], items[2]);
                }
                catch (IndexOutOfRangeException ioore)
                {
                    System.Console.WriteLine(ioore.Message);
                }
            }

            return contacts;
        }
        catch (FileNotFoundException fnfe)
        {
            System.Console.WriteLine(fnfe.Message);
            Console.ReadKey();
            return Array.Empty<(string, string, string)>();
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            Console.ReadKey();
            return Array.Empty<(string, string, string)>();
        }
    }

    void RemoveContact()
    {
        Console.Clear();
        ShowAllContacts();
        System.Console.WriteLine("Enter phone to remove:");
        var phoneToRemove = Console.ReadLine();
        if (!int.TryParse(phoneToRemove, out int value)) { throw new ArgumentException("the phone should contain only numbers", nameof(value)); }
        var contacts = ReadContacts(filePath);
        var newContacts = new (string, string, string)[contacts.Length];
        Array.Copy(contacts, newContacts, contacts.Length);

        var index = 0;

        while (index < newContacts.Length)
        {
            if (newContacts[index].Item3 == phoneToRemove)
            {
                newContacts[index] = newContacts[^1];
                Array.Resize(ref newContacts, newContacts.Length - 1);
            }
            else
            {
                ++index;
            }
        }

        var csvBuilder = new StringBuilder();
        foreach (var contact in newContacts)
        {
            csvBuilder.AppendLine(Serialize(contact));
        }
        File.WriteAllText(filePath, csvBuilder.ToString());
        System.Console.WriteLine($"{contacts.Length - newContacts.Length} Contact(s) removed, press any key to continue");
        Console.ReadKey();
    }

    void SearchContact()
    {
        Console.Clear();
        System.Console.WriteLine("Enter Last\\second name or number: ");
        string searchContact = Console.ReadLine();
        CheckCorrectInput(searchContact,"invalid input");
        var contacts = ReadContacts(filePath);
        var index = 0;
        for (int i = 0; i < contacts.Length; i++)
        {
            if (contacts[index].Item1 == searchContact
            || contacts[index].Item2 == searchContact
            || contacts[index].Item3 == searchContact)
            {
                ShowRow(contacts[i]);
            }
            else{System.Console.WriteLine("Contact not found...");}
        }
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    void UpdateContact()
    {
        Console.Clear();
        ShowAllContacts();
        var contacts = ReadContacts(filePath);

        System.Console.WriteLine("Enter the contact's number: +");
        string searchNumbContact = Console.ReadLine();
        if (!int.TryParse(searchNumbContact, out int value)) { throw new ArgumentException("the phone should contain only numbers", nameof(value)); }
        System.Console.WriteLine("enter a new name:");
        string contactNewName = Console.ReadLine();
        CheckCorrectInput(contactNewName, "incorrect last name output");
        System.Console.WriteLine("enter a new last name:");
        string contactNewLastName = Console.ReadLine();
        CheckCorrectInput(contactNewLastName, "incorrect last name output");

        var index = 0;
        for (int i = 0; i < contacts.Length; i++)
        {
            if (contacts[index].Item3 == searchNumbContact)
            {
                contacts[index].Item1 = contactNewName;
                contacts[index].Item2 = contactNewLastName;
            }
            else { System.Console.WriteLine("contacts no found"); }
        }

        var csvBuilder = new StringBuilder();
        foreach (var contact in contacts)
        {
            csvBuilder.AppendLine(Serialize(contact));
        }
        File.WriteAllText(filePath, csvBuilder.ToString());
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    void MainlMenu()
    {
        Console.Clear();
        System.Console.WriteLine("Phone Book");
        System.Console.WriteLine("Menu.");
        System.Console.WriteLine("1 - Show all contacts.");
        System.Console.WriteLine("2 - Add new contacts.");
        System.Console.WriteLine("3 - Update contacts.");
        System.Console.WriteLine("4 - Remove contacts.");
        System.Console.WriteLine("5 - Search contact.");
        System.Console.WriteLine("0 - Exit.");

        var keyPress = Console.ReadKey();

        switch (keyPress.Key)
        {
            case ConsoleKey.D0:
                ExitProg();
                break;

            case ConsoleKey.D1:
                ShowAllContacts();
                break;

            case ConsoleKey.D2:
                AddNewContacts();
                break;

            case ConsoleKey.D3:
                UpdateContact();
                break;

            case ConsoleKey.D4:
                RemoveContact();
                break;
            case ConsoleKey.D5:
                SearchContact();
                break;

            default:
                break;
        }
    };

    while (true)
    {
        MainlMenu();
    };