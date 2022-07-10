using System;
using static System.Console;
namespace ConsoleApp;

public class Topic
{
    public string Tittle {get; init;}
    public int Yes {get; private set;}
    public int No {get; private set;}

    public Topic(string tittle)
    {
        Tittle = tittle;
        WriteLine($"Topic \"{Tittle}\" was created, you can vote for or agains it!");
    }

    public void AddVote (int optionNum)
    {
        if(optionNum == 1 ) Yes++;
        else No++;
    }

    public override string ToString()
    {   
        int total = Yes + No;
        if (total == 0 ) total = 1;
        int yesPercent = Yes * 100 / total;
        int noPercent = No * 100 / total;
        return $"{Tittle} \n Yes - {Yes} ({yesPercent}%), No - {No} ({noPercent}%)";
    }

    // public void 
    // {
    //     throw new NotImplementedException;
    // }

}