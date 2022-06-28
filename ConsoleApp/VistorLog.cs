using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class VisitorLog
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer[] Customers { get; set; }

        public Book[] Books { get; set; }

        public Employees[] Employees { get; set; }
    }
}
