namespace ConsoleApp.AutoServiceHW;

class Tool
{
    public string Name { get; init; }
    public string Purpose { get; set; }

    public virtual void UseTool()
    {
        System.Console.WriteLine("I am usefull");
    }
}