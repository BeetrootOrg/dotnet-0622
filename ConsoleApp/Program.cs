using System;
using System.Linq;

using static System.Console;



var type = typeof(string);
var assembly = type.Assembly;
WriteLine($"Type of Assembly = {assembly.FullName}");

foreach (var assemblyTypes in assembly.GetTypes().Take(100))
{
    var assemblyMethods = type.GetMethods();

    foreach (var method in assemblyMethods)
    {
        WriteLine($"Mehod Name: {method.Name}");
        WriteLine($"Method Atributes: {method.Attributes}");
        WriteLine($"Method return type: {method.ReturnType}");

        var methodParams = method.GetParameters().ToList();
        foreach (var parameters in methodParams)
        {
            WriteLine($"Method {method.Name} parameters: {parameters.ParameterType}");
        }
    }
}

