using System;
using System.Collections.Generic;
using System.Linq;

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

        // 2.1
        WriteLine(ToRgb(Color.Red));

        // 2.2
        WriteLine(ToRgbReflection(Color.Blue));

        try
        {
            WriteLine(ToRgbReflection((Color)42));
        }
        catch
        {
            // ignore
        }
    }

    // 2.1 to rgb
    public static string ToRgb(Color color)
    {
        return color switch
        {
            Color.Blue => "#0000ff",
            Color.Brown => "#964b00",
            Color.Green => "#00ff00",
            Color.Red => "#ff0000",
            _ => throw new ArgumentOutOfRangeException(nameof(color))
        };
    }

    // 2.2 to rgb
    public static string ToRgbReflection(Color color)
    {
        var type = typeof(Color);
        var memberInfo = type.GetMember(color.ToString());
        if (!memberInfo.Any())
        {
            throw new ArgumentOutOfRangeException(nameof(color));
        }

        var attributes = memberInfo[0].GetCustomAttributes(typeof(RgbCodeAttribute), false);
        var rgbAttribute = (RgbCodeAttribute)attributes.Single();
        return rgbAttribute.Code;
    }
}