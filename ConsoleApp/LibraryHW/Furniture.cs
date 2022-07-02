namespace ConsoleApp.LibraryHW;

enum FurnitureType
{
    Table,
    Chair,
    Shelf,
    Lamp
}
enum FurnitureMaterial
{
    Wood,
    Plastic,
    Metal    
}
class Furniture
{
    public int Id { get; init; }
    public FurnitureType Type { get; init; }
    public FurnitureMaterial Material { get; init; }
    public bool IsOnRepair { get; set; }

    public Furniture(int id, FurnitureType type, FurnitureMaterial material, bool isOnRepair)
    {
        Id = id;
        Type = type;
        Material = material;
        IsOnRepair = isOnRepair;
    }
}