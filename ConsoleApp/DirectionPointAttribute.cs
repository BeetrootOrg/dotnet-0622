using System;
namespace ConsoleApp;

[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]

class DirectionPointAttribute : Attribute
{
    public string DirectionPoint {get; set;}
}