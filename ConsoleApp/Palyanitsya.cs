using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Palyanitsya : Bakery
    {
        public Palyanitsya()
        {
            Name = "Palyanitsa";

            Description = "Skazhi palyanitsa";

            Price = 6;

            MadeDate = new DateTime (2022, 7, 5);

            ExpirationDate = new DateTime(2022, 7, 7);
        }
    }
}
