namespace CodeConventions;

public interface Naming
{
    void InterfaceMethod();
    public int InterfaceProperty { get; set; }
}

public enum Naming
{
    True,
    False,
    NotGiven
}

internal class Naming
{
    public static int PublicStaticProperty { get; set; }
    private static int PrivateStaticProperty { get; set; }
    internal static int InternalStaticProperty { get; set; }
    protected static int ProtectedStaticProperty { get; set; }

    public static int PublicStaticField;
    private static int _privateStaticField;
    internal static int _internalStaticField;
    protected static int _protectedStaticField;

    public int PublicProperty { get; set; }
    private int PrivateProperty { get; set; }
    internal int InternalProperty { get; set; }
    protected int ProtectedProperty { get; set; }

    public int PublicField;
    private int _privateField;
    internal int _internalField;
    protected int _protectedField;

    public Naming(int publicProperty, int privateProperty, int internalProperty, int protectedProperty, int publicField, int privateField, int internalField, int protectedField)
    {
        PublicProperty = publicProperty;
        PrivateProperty = privateProperty;
        InternalProperty = internalProperty;
        ProtectedProperty = protectedProperty;
        PublicField = publicField;
        _privateField = privateField;
        _internalField = internalField;
        _protectedField = protectedField;
    }

    public void PublicMethod(int a, int b) {}
    private void PrivateMethod(int a, int b) {}
    internal void InternalMethod(int a, int b) {}
    protected void ProtectedMethod(int a, int b) {}
    public static void PublicStaticMethod(int a, int b) {}
    private static void PrivateStaticMethod(int a, int b) {}
    internal static void InternalStaticMethod(int a, int b) {}
    protected static void ProtectedStaticMethod(int a, int b) {}

    public const int PublicInt = default;
    private const int PrivateInt = default;
    internal const int InternalInt = default;
    protected const int ProtectedInt = default;
}