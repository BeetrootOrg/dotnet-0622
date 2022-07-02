namespace ConsoleApp.Library;

class Book
{
    public string Title { get; init; }
    public Person BookAuthor { get; init; }
    public Publisher BookPublisher { get; init; }
    public CategoryOfBook Category { get; init; }
}
