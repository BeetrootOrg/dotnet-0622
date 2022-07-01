using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ZAZ : Car
    {
        protected override void ignition()
        {
            Console.WriteLine("Завели з 3 разу");
        }
        public override void testdrive()
        {
            ignition();
            Console.WriteLine("Шуршим дуже акуратно");
            checkproblem();
        }
        public override void checkproblem()
        {
            Console.WriteLine("Хана мотору, глуши");
        }
    }
}
