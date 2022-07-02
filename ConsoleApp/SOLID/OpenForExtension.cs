using static System.Console;

namespace ConsoleApp.SOLID;

enum ClassType
{
    Type1,
    Type2
}

class OpenForExtensionBad
{
    public ClassType ClassType { get; set; }

    public void Show()
    {
        switch (ClassType)
        {
            case ClassType.Type1:
                WriteLine("This is Type1");
                break;
            case ClassType.Type2:
                WriteLine("This is Type2");
                break;
        }
    }
}

interface IOpenForExtensionBest
{
    void Show();
}

class OpenForExtensionBest1 : IOpenForExtensionBest
{
    public void Show() => WriteLine("This is Type1");
}

class OpenForExtensionBest2 : IOpenForExtensionBest
{
    public void Show() => WriteLine("This is Type2");
}