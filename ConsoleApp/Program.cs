using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using ConsoleApp;


var intType = typeof(Person);
var assembly = intType.Assembly;
System.Console.WriteLine($"Assymbly {assembly.FullName}");
foreach (var assemblyType in assembly.GetTypes().Take(5))
{
    System.Console.WriteLine($"Type name: {assemblyType.Name}");
    foreach (var methodInfo in assemblyType.GetMethods())
    {
        System.Console.WriteLine($"Metod info: {methodInfo.Name}");

        foreach (var argumentInfo in methodInfo.GetGenericArguments())
        {
            System.Console.WriteLine($"Arg info: {argumentInfo.Name}");
        }
    }


}

