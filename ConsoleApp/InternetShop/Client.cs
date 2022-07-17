using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp.InternetShop
{
    internal class Client : Human
    {
        private int ClientId { get; init; }
        public string UserName { get; init; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Receipt Receipt { get; set; }

        public Client() {  }

        public Client(int clientId,string firstName,string lastName)
        {
            ClientId = clientId;
            FirstName  = firstName;
            LastName = lastName;
            Receipt = new Receipt();
        }
        public Client(int clientId, string firstName, string lastName, string userName = "default name", string email = "default email", string phoneNumber = "default phone number") : this(clientId,firstName,lastName)
        {
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public Client(Client client)
        {
            ClientId = client.ClientId;
            FirstName = client.FirstName;
            LastName = client.LastName;
            UserName = client.UserName;
            Email = client.Email;
            PhoneNumber = client.PhoneNumber;
            Receipt = client.Receipt;
        }
        public override string ToString()
        {
            return $"Client ID: {ClientId.ToString()} | Name: {FirstName + " " + LastName} | Email : {Email} | Phone Number : {PhoneNumber} ";
        }

        public int GetClientId() => ClientId;

    }

    interface IClientReceipt : IReceiptClear
    {
        public void PutInStash(Product product);
        public void ReceiptClear();

    }
}
