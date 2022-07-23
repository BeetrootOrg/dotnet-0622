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
