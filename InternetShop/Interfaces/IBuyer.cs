namespace InternetShop.Classes;

interface IBuyer
{
    int GenerateIDNumber();
    Order GetOrder(string idNumber);

}