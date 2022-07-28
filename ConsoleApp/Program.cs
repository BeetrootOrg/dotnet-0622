using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var stringType = typeof(int);
        var assembly = stringType.Assembly;

        Console.WriteLine($"Assmebly full name: {assembly.FullName}");

        foreach (var assemblyType in assembly.GetTypes().Take(40))
        {
            Console.WriteLine($"Assembly type name is {assemblyType.Name}");
            Console.WriteLine($"Type is Class {assemblyType.IsClass}");
            Console.WriteLine($"Type is Interface {assemblyType.IsInterface}");

            var methodsFromAssembly = assemblyType.GetMethods();

            foreach (var method in methodsFromAssembly)
            {
                Console.WriteLine($"Method information {method}");
                Console.WriteLine($"Method return type {method.ReturnType}");

                var parameters = method.GetParameters().ToList();

                foreach (var parameter in parameters)
                {
                    Console.WriteLine($"Method parameters {parameter.ParameterType}");
                }
            }
        }

    }
}