using System;

namespace ConsoleApp;

class Person : IEquatable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; }
    public byte Height { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Person person)
        {
            return Equals(person);
        }

        return false;
    }

    public bool Equals(Person other)
    {
        if (other == null)
        {
            return false;
        }

        return FirstName == other.FirstName &&
            LastName == other.LastName &&
            Weight == other.Weight &&
            Height == other.Height;
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(FirstName);
        hashCode.Add(LastName);
        hashCode.Add(Weight);
        hashCode.Add(Height);
        return hashCode.ToHashCode();
    }

    public override string ToString()
    {
        return $"{{{nameof(FirstName)}: {FirstName}, " +
            $"{nameof(LastName)}: {LastName}, " +
            $"{nameof(Weight)}: {Weight}, " +
            $"{nameof(Height)}: {Height}}}";
    }
}