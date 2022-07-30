namespace LinqLesson;

struct DistanceBetweenPersons
{
    public Person FirstPerson { get; init; }
    public Person SecondPerson { get; init; }
    public double DistacneBetween { get; init; }

    public DistanceBetweenPersons(Person firstPerson, Person secondPerson, double distacneBetween)
    {
        FirstPerson = firstPerson;
        SecondPerson = secondPerson;
        DistacneBetween = distacneBetween;
    }

    public override string ToString()
    {
        return $"Distance between {FirstPerson.Name} and {SecondPerson.Name} is {DistacneBetween} km";
    }
}