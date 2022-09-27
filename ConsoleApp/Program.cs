using System;

using System.IO;

using static System.Console;

using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {
        Vote vote = Vote.Instance();
        ConsoleInterface user = new ConsoleInterface(ref vote);
        while (true)
        {
            user.MainMenu();
        }
    }
}
