using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public byte Age { get; set; }

        public Teacher[] Teachers { get; set; }
    }
}
