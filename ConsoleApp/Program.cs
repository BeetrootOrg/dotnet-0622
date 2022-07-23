using System.Reflection;

Type myType = typeof(DateTime);

Console.WriteLine("Rows:");
foreach (FieldInfo field in myType.GetFields(
    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
{
    string mod = "";
    if (field.IsPublic)
        mod += "public ";
    else if (field.IsPrivate)
        mod += "private ";
    else if (field.IsAssembly)
        mod += "internal ";
    else if (field.IsFamily)
        mod += "protected ";
    else if (field.IsFamilyAndAssembly)
        mod += "private protected ";
    else if (field.IsFamilyOrAssembly)
        mod += "protected internal ";
    if (field.IsStatic) mod += "static ";

    Console.WriteLine($"{mod}{field.FieldType.Name} {field.Name}");
}


foreach (PropertyInfo prop in myType.GetProperties(
    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
{
    Console.Write($"{prop.PropertyType} {prop.Name} {{");
    if (prop.CanRead) Console.Write("get;");
    if (prop.CanWrite) Console.Write("set;");
    Console.WriteLine("}");
}

foreach (MethodInfo method in myType.GetMethods())
{
    string mod = "";

    if (method.IsStatic)
        mod += "static ";
    if (method.IsVirtual)
        mod += "virtual ";
    Console.WriteLine($"{mod}{method.ReturnType.Name} {method.Name} ()");
}

foreach (MethodInfo method in myType.GetMethods())
{
    Console.Write($"{method.ReturnType.Name} {method.Name} (");
    ParameterInfo[] parameters = method.GetParameters();
    for (int i = 0; i < parameters.Length; i++)
    {
        var param = parameters[i];
        string mod = "";
        if (param.IsIn)
            mod = "in";
        else if (param.IsOut)
            mod = "out";
        Console.Write($"{param.ParameterType.Name} {mod} {param.Name}");
        if (param.HasDefaultValue)
            Console.Write($"={param.DefaultValue}");
        if (i < parameters.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine(")");
}


