namespace CalendarApp;

interface ICodeConvention
{
    public int Property { get; init; }
    public void GetSmth()
    {
    }
}
public class CodeConvention : ICodeConvention
{
    // STATIC FIELDS
    public static int PascalCaseField;
    internal static int _lowerCamalCaseField;
    protected static int _lowerCamalCaseField;
    private static int _lowerCamalCaseField;

    // STATIC PROPERTIES
    public static int PascalCaseProp { get; set; }
    internal static int PascalCaseProp { get; set; }
    protected static int PascalCaseProp { get; set; }
    private static int PascalCaseProp { get; set; }

    // FIELDS
    public int PascalCaseField;
    internal int _lowerCamalCaseField;
    protected int _lowerCamalCaseField;
    private int _lowerCamalCaseField;

    // POPERTIES
    public static int PascalCaseProp { get; set; }
    internal static int PascalCaseProp { get; set; }
    protected static int PascalCaseProp { get; set; }
    private static int PascalCaseProp { get; set; }

    // CONSTRUCTOR
    public CodeConvention(int pascalCaseField, int lowerCamalCaseField)
    {
        PascalCaseField = pascalCaseField;
        _lowerCamalCaseField = lowerCamalCaseField;
    }

    // METHODS WITH ALL ACCESS MODIFIERS
    public int Sum(int a, int b);
    internal int Delete(int a, int b);
    protected int Multiply(int a, int b);
    private int Divide(int a, int b);

    // STATIC METHODS WITH ALL ACCESS MODIFIERS
    public static bool IsOdd(int a);
    internal static void ToDoSmth(int a, string smth);
    protected static string ToConvert(string text);
    private static string ToTranslate(string text);

    // CONSTANTS
    public const int ConstantPascalCase = 9;

    // ENUM
    public enum Color
    {
        Red,
        Green,
        Blue,
        Yellow
    }
}