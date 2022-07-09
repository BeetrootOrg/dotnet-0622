namespace ConsoleApp.AutoService;
class Client : Human
{
    private int _id;

    private int _carId;
    public DateTime CarInWork { get; set; }

    public override string Say() => base.Say() + "Thanks for your work, here`s your payment";

    public decimal Pay(decimal invoice)
    {
        throw new NotImplementedException();
    }
}