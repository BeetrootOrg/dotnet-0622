namespace ConsoleApp.AutoService;
internal class Vehicle
{
    private int _id { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Manufacturer { get; set; }
    public DateTime ProductionData { get; set; }

    virtual public string MakeNoize() => "Brrr";
    public string GetId() => _id.ToString();
}