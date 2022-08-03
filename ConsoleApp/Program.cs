var assembly = typeof(char).Assembly;
System.Console.WriteLine($"Assembly full name: {assembly.FullName}" +"\n");
foreach (var assemblyType in assembly.GetTypes())
{
    System.Console.WriteLine($"Type name: {assemblyType.Name}");

    foreach (var assemblyTypeMethod in assemblyType.GetMethods())
    {
        System.Console.WriteLine($"Method: {assemblyTypeMethod}. Return type: {assemblyTypeMethod.ReturnType}");
        foreach (var assemblyTypeParameters in assemblyTypeMethod.GetParameters())
        {
            System.Console.WriteLine($"Argument needed to pass: {assemblyTypeParameters}");
        }
    }
    System.Console.WriteLine();
}