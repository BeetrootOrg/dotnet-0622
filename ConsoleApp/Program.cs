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
        var intType = typeof(int);
        var assembly = intType.Assembly;
        WriteLine($"Assembly {assembly.FullName}");
        foreach (var assemblyType in assembly.GetTypes().Take(30))
        {
            WriteLine($"Type name: {assemblyType.Name}");

            foreach (var methodInfo in assemblyType.GetMethods())
            {
                WriteLine($"Method info: {methodInfo}");
                WriteLine($"Method return type: {methodInfo.ReturnType}");

                var methodParameters = methodInfo.GetParameters();
                foreach (var parameter in methodParameters)
                {
                    WriteLine($"Method parameters: {parameter.ParameterType}");
                }
            }
        }
    }
}










