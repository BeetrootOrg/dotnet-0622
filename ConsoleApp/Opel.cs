using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Opel : Car
    {
        protected override void ignition()
        {
            Console.WriteLine("Якось завели авто");
        }
        public override void testdrive()
        {
            ignition();
            Console.WriteLine("Шуршим не дуже швидко");
        }
    }
}
