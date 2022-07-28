using System;


internal class Program
{
    private static void Main(string[] args)
    {
        var assembly = typeof(string).Assembly.Take(20);
        foreach (var assemblyType in assembly)
        {
            Console.WriteLine($"Assembly name is");
        }

    }
}