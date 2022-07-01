using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Porsche : Car
    {
        public override void testdrive()
        {
            ignition();
            Console.WriteLine("Валим на всi бабки, дiвки всi мої");
        }
    }
}
