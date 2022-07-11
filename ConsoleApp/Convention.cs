namespace ConsoleApp;

public class Convention
{
    #region Fields

    private int _privateField;
    protected int ProtectedField;
    internal int InternalField;
    public int PublicField;

    #endregion

    #region Properties

    private int PrivateProperty { get; set; }
    protected int ProtectedProperty { get; set; }
    internal int InternalProperty { get; set; }
    public int PublicProperty { get; set; }

    #endregion
}