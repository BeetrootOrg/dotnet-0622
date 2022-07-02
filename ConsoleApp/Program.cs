using ConsoleApp.LibraryHW;

namespace ConsoleApp;

partial class Program
{
    static void Main()
    {
        Worker cleaner = new Worker("Cleaner", "Mary", "Jane");
        Worker librarian = new Worker("Librarian", "Danyl", "Bloggs");
        Worker owner = new Worker("Owner", "Sami", "Knott");
        Worker[] workers = {cleaner, librarian, owner};

        Furniture table = new Furniture(1, FurnitureType.Table, FurnitureMaterial.Wood, false);
        Furniture lamp = new Furniture(2, FurnitureType.Lamp, FurnitureMaterial.Plastic, false);
        Furniture chair = new Furniture(3, FurnitureType.Chair, FurnitureMaterial.Metal, true);
        Furniture shelf = new Furniture(4, FurnitureType.Shelf, FurnitureMaterial.Wood, false);
        Furniture[] furniture = {table, lamp, chair, shelf};

        Author sapkowski = new Author("Andrzej", "Sapkowski", new DateOnly(1948, 6, 21));
        Author troelsen = new Author("Andrew", "Troelsen", new DateOnly(1940, 7, 10));

        Book swordOfDestiny = new Book("Sword of Destiny", sapkowski, true);
        Book lastWish = new Book("The Last Wish", sapkowski, true);
        Book bloodOfElves = new Book("Blood of Elves", sapkowski, false);
        Book ladyOfTheLake = new Book("The Lady of the Lake", sapkowski, true);
        Book[] withcerSaga = {swordOfDestiny, lastWish, bloodOfElves, ladyOfTheLake};

       
        Book cSharp = new Book("C# and the .Net Platform", troelsen, true);
        Book visualBasic = new Book("Visual Basic .Net and the .Net Platform: An Advanced Guide", troelsen, true);
        Book[] dotNet = {cSharp, visualBasic};

        Section fantasy = new Section("Fantasy", withcerSaga);
        Section programming = new Section("Programming", dotNet);
        Section[] sections = {fantasy, programming};
        
        Library library = new Library("The British Library", sections, workers, furniture);
    }
}
