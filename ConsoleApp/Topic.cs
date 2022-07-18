using System.Collections.Generic;

namespace ConsoleApp;

public class Topic
{
    public string NameTopic { get; set; }
    public string FirstTopic { get; set; }
    public string SecondTopic { get; set; }
    public int FirstCounter {get; set; }
    public int SecondCounter {get; set; }

    public override string ToString()
    {
        return $"1.{FirstTopic} - {FirstCounter} votes\n2.{SecondTopic} - {SecondCounter} votes";
    }
}
