using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Drive(Car car)
        {
            car.testdrive();
        }
    }
}
