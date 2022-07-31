using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp;

using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {

        var intType = typeof(int);
        var assembly = intType.Assembly;
        WriteLine($"Assymbly {assembly.FullName}");
        foreach (var assemblyType in assembly.GetTypes().Take(20))
        {
            WriteLine($"Type name: {assemblyType.Name}");
            WriteLine($"Type class: {assemblyType.IsClass}");

            var methodAssembly = assemblyType.GetMethods();
            foreach (var methodInfo in assemblyType.GetMethods())
            {
                WriteLine($"Method info: {methodInfo}");
                WriteLine($"Method return type: {methodInfo.ReturnType}");

                var methodParameters = methodInfo.GetParameters();
                foreach (var parameter in methodParameters)
                {
                    WriteLine($"Method parametrs: {parameter.ParameterType}");
                }

            }
        }
    }
}