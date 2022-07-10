using System;
using static System.Console;
namespace ConsoleApp;

public record Topic
{
    public string Tittle {get; init;}
    public int Yes {get;}
    public int No {get;}

    public Topic(string tittle)
    {
        Tittle = tittle;
        WriteLine($"Topic \"{Tittle}\" was created, you can vote for or agains it!");
    }

    public void 
    {

    }

}