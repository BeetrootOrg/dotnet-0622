using System;
using static System.Console;
using System.Reflection;
using System.Linq;
using ConsoleApp;


Snake testSnake = new Snake();
var typeSnake = testSnake.GetType();
var assemblySnake = typeSnake.Assembly;

foreach (var type in assemblySnake.GetTypes())
{
    WriteLine($"Class: {type.Name}");

    foreach (var method in type.GetMethods())
    {
        string parameters = string.Join(' ', method.GetParameters().Select(x => x.ParameterType));
        if (string.IsNullOrWhiteSpace(parameters))
        {
            parameters = "none";
        }
        WriteLine($"Method: {method.Name}, Parameter: {parameters}, Return parameter: {method.ReturnParameter}");
    }
}