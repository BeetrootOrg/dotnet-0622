using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Pepsi : NonAlcohol
    {
        public Pepsi()
        {
            Name = "Pepsi 0.5";
            
            Description = "0.5 dlyz patsaniv";

            Price = 6;
            
            MadeDate = new DateTime(2022,06,11);
                
        }
    }
}
