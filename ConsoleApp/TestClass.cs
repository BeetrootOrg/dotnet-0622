namespace ConsoleApp;

delegate void OnChangeHandler();

class TestClass
{
    private int _number;
    private string _text;

    public int Number
    {
        get => _number;
        set
        {
            _number = value;
            _onChangeHandler();
        }
    }

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            _onChangeHandler();
        }
    }

    private OnChangeHandler _onChangeHandler;

    public TestClass(OnChangeHandler onChangeHandler)
    {
        _onChangeHandler = onChangeHandler;
    }
}