using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.InternetShop
{
    class Randomizer
    {

       public string Randomize(int range)
        {
            Random random = new Random(Environment.TickCount);
            return range.GetHashCode().ToString() + random.Next(1, 300).ToString();
        }
        public int Randomize(int minRange, int maxRange)
        {
            Random random = new Random(Environment.TickCount);
            return minRange.GetHashCode() + maxRange.GetHashCode() + random.Next(minRange, maxRange);
        }
    }
}
