using System;

namespace ConsoleApp;

class Car
{
    public string Name { get; init; }
    public int Power { get; init; }
    public string Color { get; init; }
}

class CarBuilder
{
    private string _name;
    private int _power;
    private string _color;

    public CarBuilder SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentOutOfRangeException(nameof(name));
        }

        _name = name;
        return this;
    }

    public CarBuilder SetPower(int power)
    {
        if (power <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(power));
        }

        _power = power;
        return this;
    }

    public CarBuilder SetColor(string color)
    {
        if (string.IsNullOrEmpty(color))
        {
            throw new ArgumentOutOfRangeException(nameof(color));
        }

        _color = color;
        return this;
    }

    public Car Build()
    {
        if (_power == 0 || string.IsNullOrEmpty(_color) || string.IsNullOrEmpty(_name))
        {
            throw new Exception();
        }

        return new Car
        {
            Color = _color,
            Name = _name,
            Power = _power
        };
    }
}