using System.Linq;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        var stringType = typeof(int);
        var assembly = stringType.Assembly;

        WriteLine($"Assmebly full name: {assembly.FullName}");

        foreach (var assemblyType in assembly.GetTypes().Take(20))
        {
            WriteLine($"Assembly type name is {assemblyType.Name}");
            WriteLine($"Type is Class {assemblyType.IsClass}");

            var methodsFromAssembly = assemblyType.GetMethods();

            foreach (var method in methodsFromAssembly)
            {
                WriteLine($"Method information {method}");
                WriteLine($"Method return type {method.ReturnType}");

                var parameters = method.GetParameters().ToList();

                foreach (var parameter in parameters)
                {
                    WriteLine($"Method parameters {parameter.ParameterType}");
                }
            }
        }
    }
}