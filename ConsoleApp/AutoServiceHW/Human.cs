namespace ConsoleApp.AutoServiceHW;

class Human
{
    public string FullName { get; init; }
    public string CityOfLiving { get; set; }

    public virtual void PerformAction(Tool tool)
    {
        tool.UseTool();
    }
}