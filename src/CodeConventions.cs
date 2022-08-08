namespace ConsoleApp;

interface IInterface
{
    public void Action();
    public void Show();
}

public class ClassName
{
    public static int PublicStaticIntProperty { get; set; }
    private static int PrivateStaticIntProperty { get; set; }
    internal static int InternalStaticIntProperty { get; set; }
    protected static int ProtectedStaticIntProperty { get; set; }


    public static int PublicStaticIntField;
    private static int _privateStaticIntField;
    internal static int _internalStaticIntField;
    protected static int _protectedStaticIntField;

    public int PublicIntProperty { get; set; }
    private int PrivateIntProperty { get; set; }
    internal int InternalIntProperty { get; set; }
    protected int ProtectedIntProperty { get; set; }

    public int PublicIntField;
    private int _privateIntField;
    internal int _internalField;
    protected int _protectedIntField;


    public ClassName(int FirstArgument, int SecondArgument, int ThirdArgument, int ForthArgument, int FifthArgument)
    {
        PublicIntField = FifthArgument;
        PublicStaticIntField = SecondArgument;
        _privateIntField = ThirdArgument;
        _protectedIntField = ForthArgument;
        _internalStaticIntField = FifthArgumentl;

    }

    public void PublicMethod(int FirstArgument, int SecondArgument);
    private void PrivateMethod(int FirstArgument, int SecondArgument);
    internal void InternalMethod(int FirstArgument, int SecondArgument);
    protected void ProtectedMethod(int FirstArgument, int SecondArgument);

    public static void PublicStaticMethod(int FirstArgument, int SecondArgument);
    private static void PrivateStaticMethod(int FirstArgument, int SecondndArgument);
    internal static void InternalStaticMethod(int FirstArgument, int Secorgument);
    protected static void ProtectedStaticMethod(int FirstArgument, int SecondAgument);


    public int PublicConstantValue = 0;
    private int PrivateConstantValue = 0;
    internal int InternalConstantValue = 0;
    protected int ProtectedConstantValue = 0;

}