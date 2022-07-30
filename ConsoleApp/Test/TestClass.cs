namespace ConsoleApp.Test;

class TestClass
{
    public string getAdditionString(int a, int b)
    {
        return (a + b).ToString();
    }

    public void ShowHello(string phrase)
    {
        System.Console.WriteLine("Hello " + phrase);
    }

    public TestClass ReturnSelf()
    {
        return this;
    }
}