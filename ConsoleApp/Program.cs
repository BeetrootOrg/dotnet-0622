using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

using ConsoleApp;

using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
    //All the classes
    Assembly myAssembly = typeof(Snake).Assembly;

    foreach (Type type in myAssembly.GetTypes())
    {
        if(type.IsClass)
        {   
            WriteLine(type.FullName);
            var thisType = type.GetType();
            foreach (var propertyInfo in thisType.GetProperties())
            {
                WriteLine($"The property type: {propertyInfo}");
            }

        } 

        var parameters = type.GetFields();
               foreach (var parameter in parameters)
               {
                   WriteLine($"The field is: {parameter}");
               }
        
         foreach (var methodInfo in type.GetMethods())
            {
               WriteLine(methodInfo);
               
            }
    }
    }
}