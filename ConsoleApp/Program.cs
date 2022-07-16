using System.Collections.Generic;
namespace ConsoleApp;

class Program : MainMenu
{


    static void Main(string[] args)
    {

        while (true)
        {
            MainMenu MyMenu = new MainMenu();
            MyMenu.FirstMenu();
        }
  
        

    }
}