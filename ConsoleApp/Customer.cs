using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Customer : Person
    {
        public void Drive(Car car)
        {
            car.testdrive();
        }
    }
}
