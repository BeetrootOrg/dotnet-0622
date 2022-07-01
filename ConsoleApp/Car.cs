using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Car
    {
        public string Brand { get; set; }
        public string Age { get; set; }

        protected virtual void ignition()
        {
            Console.WriteLine("Завели  двигун");
        }
        public virtual void checkproblem()
        {
            Console.WriteLine("Перевірка на проблеми завершена");
        }

        public virtual void testdrive()
        {
            ignition();
            Console.WriteLine("Шуршим з середньою швидкiстю");
        }
    }
}
