namespace ConsoleApp.AutoService;

class Volkswagen : Vehicle
{
    private int _volkswagenId { get; set; }
    public DateTime AssemblyDate { get; set; }
    public string FullName { get => "Volkswagen motors " + base.Name; }

    public override string MakeNoize() => base.MakeNoize() + "Khkhkhk";

    public string FullId() => base.GetId() + _volkswagenId.ToString();

}