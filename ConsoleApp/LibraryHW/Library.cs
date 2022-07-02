namespace ConsoleApp.LibraryHW;
class Library
{
    public string Name { get; init; }
    public Section[] LibSections { get; set; }
    public Worker[] LibWorkers { get; set; }
    public Furniture[] LibFurniture { get; set; }

    public Library(string name, Section[] libSections, Worker[] libWorkers, Furniture[] libFurniture)
    {
        Name = name;
        LibSections = libSections;
        LibWorkers = libWorkers;
        LibFurniture = libFurniture;
    }
}