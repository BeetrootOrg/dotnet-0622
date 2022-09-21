using System;

using System.IO;

using static System.Console;

using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {
        Vote votes =  Vote.Instance();
        ConsoleInterface user = new ConsoleInterface(ref votes);
        while (true)
        {
             user.MainMenu();
        }
    }
}
