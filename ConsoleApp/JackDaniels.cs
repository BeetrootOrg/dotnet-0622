using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class JackDaniels : Alcohol
    {
        public JackDaniels ()
        {
            Name = "Jack Daniels";
            Description = "Viskey";
            Price = 111143 ;
            MadeDate = new DateTime(2020, 10, 8);
            ExpirationDate = new DateTime(2030, 12, 1);
            Strength = 40;
    }
    }
}
