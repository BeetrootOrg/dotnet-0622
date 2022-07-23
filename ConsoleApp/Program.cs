using System.Collections.Generic;

using ConsoleApp;

using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        var testClass = new TestClass
        {
            Number = 42,
            Text = "this is text",
            Is = true,
            Real = 15.5f
        };

        // 1.1. show all properties in console
        WriteLine($"{testClass.Number},{testClass.Text},{testClass.Is},{testClass.Real}");

        // 1.2. show all properties in console
        var type = testClass.GetType();
        var values = new List<object>();
        foreach (var propertyInfo in type.GetProperties())
        {
            values.Add(propertyInfo.GetValue(testClass));
        }

        WriteLine(string.Join(',', values));
    }
}