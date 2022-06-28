using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Classroom
    {
        public string Subject { get; set; }
        public byte Square { get; set; }
        public Boolean IsPCAvialable { get; set; }

        public Teacher Myteacher { get; set; }

        public Student[] Students { get; set; }
    }
}
