namespace ConsoleApp.Library;
class Book
{
    public PublishingHouse PublishingHouse { get; init; }
    public Author[] Authors { get; init; }
    public string Name { get; init; }
    public string Genre { get; init; }
    public string YearOfPublication  { get; init; }
    public string Annotation { get; init; }
    public string Language { get; init; }
}