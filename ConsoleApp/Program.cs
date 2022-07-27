using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using ConsoleApp;

using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        var testClass = new TestClass()
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

        // // 2.1
        // WriteLine(ToRgb(Color.Red));

        // // 2.2
        // WriteLine(ToRgbReflection(Color.Blue));

        // try
        // {
        //     WriteLine(ToRgbReflection((Color)42));
        // }
        // catch
        // {
        //     // ignore
        // }

        // 3.1. create class
        var testClass1 = Activator.CreateInstance(typeof(TestClass));
        foreach (var propertyInfo in typeof(TestClass).GetProperties())
        {
            if (propertyInfo.PropertyType == typeof(int))
            {
                propertyInfo.SetValue(testClass1, 42);
            }
            else if (propertyInfo.PropertyType == typeof(string))
            {
                propertyInfo.SetValue(testClass1, "test");
            }
            else if (propertyInfo.PropertyType == typeof(bool))
            {
                propertyInfo.SetValue(testClass1, true);
            }
            else if (propertyInfo.PropertyType == typeof(float))
            {
                propertyInfo.SetValue(testClass1, 2.5f);
            }
        }

        values.Clear();
        foreach (var propertyInfo in type.GetProperties())
        {
            values.Add(propertyInfo.GetValue(testClass1));
        }

        WriteLine(string.Join(',', values));

        // 4. comparison get & get with reflection
        var sw1 = new Stopwatch();
        sw1.Start();
        for (int i = 0; i < 1000000; i++)
        {
            var value = testClass.Number;
            ++value;
        }
        sw1.Stop();

        var sw2 = new Stopwatch();
        var numberPropertyInfo = type.GetProperty("Number");

        sw2.Start();
        for (int i = 0; i < 1000000; i++)
        {
            var value = (int)numberPropertyInfo.GetValue(testClass);
            ++value;
        }
        sw2.Stop();

        WriteLine($"Simple get: {sw1.ElapsedMilliseconds}");
        WriteLine($"Reflection get: {sw2.ElapsedMilliseconds}");

        // HOMEWORK 
        System.Console.Clear();
        System.Console.WriteLine();
        System.Console.WriteLine("-------------------------------------------------------");
        var intType = typeof(int);
        var assembly = intType.Assembly;
        WriteLine($"Assymbly {assembly.FullName}");

        foreach (var assemblyType in assembly.GetTypes().Take(20))
        {
            System.Console.WriteLine("");
            WriteLine("-------------------------------------------------------");
            WriteLine($"Type name: {assemblyType.Name}");
            WriteLine($"Full Name: {assemblyType.FullName}");
            WriteLine($"Is struct: {assemblyType.IsValueType}");
            WriteLine($"Is class: {assemblyType.IsClass}");
            WriteLine($"Is Interface: {assemblyType.IsInterface}");


            var allMethodsFromAssambly = assemblyType.GetMethods();
            foreach (var methodInfo in allMethodsFromAssambly)
            {
                // ...
                WriteLine("methodInfo -- " + methodInfo);
                var methodparams = methodInfo.GetParameters();
                foreach (var param in methodparams)
                {
                    WriteLine("param name =  " + param.Name + "  type =  " + param.ParameterType);           
                }
            }

            if (assemblyType.IsClass)
            {
                var classMembers = assemblyType.GetMembers();
                System.Console.WriteLine("class members : ");
                foreach (var memberInfo in classMembers)
                {
                    WriteLine("member name =  " + memberInfo.Name + " \ttype =  " + memberInfo.MemberType);                  
                }

                var classfields = assemblyType.GetFields();               
                System.Console.WriteLine("class fields : ");
                foreach (var fieldInfo in classfields)
                {
                    WriteLine("field name =  " + fieldInfo.Name + "   IsPrivate =  " + fieldInfo.IsPrivate);                         
                }
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("-------------------------------------------------------");

    }

    // // 2.1 to rgb
    // public static string ToRgb(Color color)
    // {
    //     return color switch
    //     {
    //         Color.Blue => "#0000ff",
    //         Color.Brown => "#964b00",
    //         Color.Green => "#00ff00",
    //         Color.Red => "#ff0000",
    //         _ => throw new ArgumentOutOfRangeException(nameof(color))
    //     };
    // }

    // // 2.2 to rgb
    // public static string ToRgbReflection(Color color)
    // {
    //     var type = typeof(Color);
    //     var memberInfo = type.GetMember(color.ToString());
    //     if (!memberInfo.Any())
    //     {
    //         throw new ArgumentOutOfRangeException(nameof(color));
    //     }

    //     var attributes = memberInfo[0].GetCustomAttributes(typeof(RgbCodeAttribute), false);
    //     var rgbAttribute = (RgbCodeAttribute)attributes.Single();
    //     return rgbAttribute.Code;
    // }
}