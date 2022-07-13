using System;

namespace ConsoleApp;

interface IDecorable
{
    void Method();
}

sealed class Decorable : IDecorable
{
    public void Method()
    {
        Console.WriteLine("I'm inside method");
    }
}

class Decorator : IDecorable
{
    private readonly IDecorable _decorable;

    public Decorator(IDecorable decorable)
    {
        _decorable = decorable;
    }

    public void Method()
    {
        Console.WriteLine("Decorated.");
        _decorable.Method();
    }
}