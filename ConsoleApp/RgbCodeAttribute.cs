using System;

namespace ConsoleApp;

[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
class RgbCodeAttribute : Attribute
{
    public string Code { get; init; }
}