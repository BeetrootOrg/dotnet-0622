namespace Shop;

internal class Storehouse
{
    private int _number { get; init; }
    private string _typeOfStorehouse {get; set;}
    public string[] Products { get; init; }
}

interface IresuplyProducts : IProduct, IResupply
{
    abstract void IProduct();
    public void IResupply();
}