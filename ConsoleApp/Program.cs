using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Type stringType = typeof(ConsoleApp.Test.TestClass);
        System.Reflection.Assembly assembly = stringType.Assembly;
        System.Console.WriteLine("New");
        Type[] types = assembly.GetTypes();

        string line = new string('-', 10);
        foreach (var type in types)
        {
            if (!type.IsClass) continue;
            System.Console.WriteLine($"{line}Class {type.Name}{line}" );
            foreach(var method in type.GetMethods()) 
            {
                string arguments = "";
                foreach (var parameter in method.GetParameters())
                {
                    arguments += parameter + " ";
                }

                System.Console.WriteLine($"{method.Name} method takes {(!String.IsNullOrWhiteSpace(arguments) ? arguments : "nothing")} and returns {method.ReturnParameter}");
                System.Console.WriteLine();
            }
        }
    }
}