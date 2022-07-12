using System;
using static System.Console;
namespace ConsoleApp;
using System.Linq;
using System.Collections.Generic;

public class Topic
{
    public string Tittle {get; init;}

    public Dictionary<string, int> VoteOptions {get; private set;} 

    public Topic(string tittle, string options)
    {
        Tittle = tittle;
        VoteOptions = new Dictionary<string, int>();
       
        var optionArr = options.Split(',');

        foreach (var option in optionArr)
        {
            VoteOptions.Add(option, 0);
        }

        WriteLine($"Topic \"{Tittle}\" was created, you can vote for or agains it!");

        foreach(KeyValuePair<string, int> option in VoteOptions)
          {
              Console.WriteLine("{0}: {1} votes", 
                          option.Key, option.Value);
          }
    }

    public void AddVote (int optionNum)
    {
       string key = VoteOptions.Keys.ElementAt(optionNum - 1);
       VoteOptions[key]++;
       // VoteOptions[optionNum]++;
    }

    public override string ToString()
    {   
        int total = 0;
        //WriteLine(VoteOptions.Keys.ElementAt(1));
        foreach (var option in VoteOptions)
        {
            total += option.Value;
        }

        if (total == 0 ) total = 1;
        
        string result = $"{Tittle} \n";
        int percents = 0;
        int num = 0;

        foreach (KeyValuePair<string, int> option in VoteOptions)
        {
            percents = option.Value * 100 / total;
            result += $"{++num} {option.Key} - {option.Value} votes ({percents}%) | ";
        }
        return result;
        
    }
}