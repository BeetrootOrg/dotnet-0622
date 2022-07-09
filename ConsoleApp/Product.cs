using System;

namespace ConsoleApp;

class Product : IEquatable<Product>
{
    public string Name { get; init; }
    public int Price { get; init; }

    public override string ToString()
    {
        return $"{{{nameof(Name)}: {Name}, " +
            $"{nameof(Price)}: {Price}}}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Product product)
        {
            return Equals(product);
        }

        return false;
    }

    public bool Equals(Product other)
    {
        if (other == null)
        {
            return false;
        }

        return Name == other.Name &&
            Price == other.Price;
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Name);
        hashCode.Add(Price);
        return hashCode.ToHashCode();
    }
}