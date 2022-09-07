namespace InternetShop.Classes;

internal abstract class Person
{
    private protected string FirstName { get; init; }
    private protected string LastName { get; init; }
    private protected string PatronymicName { get; init; }
    private DateTime Birthday { get; init; }
    private protected string Sex { get; init; }
    private protected string Adress { get; set; }
    private protected string NumberPhone { get; set; }
    private protected string Email { get; set; }

    private protected abstract string GetStandartName();

    private protected abstract DateTime GetAge();

    private protected abstract string GetCity();

}