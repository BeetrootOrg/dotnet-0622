using System.Numerics;
using static System.Console;

namespace ConsoleApp;

class Program
{
    private static void Main(string[] args)
    {
        BigInteger bigInt = new BigInteger(123);
        var types = bigInt.GetType().Assembly.GetTypes();
        
        WriteLine($"{bigInt.GetType().Assembly.GetName().Name} contains:");
        foreach (var type in types)
        {
            if (!type.IsClass) continue;
            WriteLine($"\t Class {type.Name} contains next methods:");
            foreach (var method in type.GetMethods())
            {
                WriteLine($"\t\t{method.ReturnType.ToString().Split('.').Last()} {method.Name} ({string.Join(',',method.GetParameters().ToList())})");
            }   
        }
    }
}