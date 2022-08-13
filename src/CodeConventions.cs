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
    internal static int InternalStaticIntField;
    protected static int ProtectedStaticIntField;

    public int PublicIntProperty { get; set; }
    private int PrivateIntProperty { get; set; }
    internal int InternalIntProperty { get; set; }
    protected int ProtectedIntProperty { get; set; }

    public int PublicIntField;
    private int _privateIntField;
    internal int InternalField;
    protected int ProtectedIntField;


    public ClassName(int FirstArgument, int SecondArgument, int ThirdArgument, int ForthArgument, int FifthArgument)
    {
        PublicIntField = FifthArgument;
        PublicStaticIntField = SecondArgument;
        _privateIntField = ThirdArgument;
        ProtectedIntField = ForthArgument;
        InternalStaticIntField = FifthArgumentl;

    }

    public void PublicMethod(int firstArgument, int secondArgument){}
    private void PrivateMethod(int firstArgument, int secondArgument){}
    internal void InternalMethod(int firstArgument, int secondArgument){}
    protected void ProtectedMethod(int firstArgument, int secondArgument){}

    public static void PublicStaticMethod(int firstArgument, int secondArgument){}
    private static void PrivateStaticMethod(int firstArgument, int secondndArgument){}
    internal static void InternalStaticMethod(int firstArgument, int secorgument){}
    protected static void ProtectedStaticMethod(int firstArgument, int secondAgument){}


    public int PublicConstantValue = 0;
    private int PrivateConstantValue = 0;
    internal int InternalConstantValue = 0;
    protected int ProtectedConstantValue = 0;

}