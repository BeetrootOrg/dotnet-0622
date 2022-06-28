﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Book
    {

        public string Title { get; set; }
        public int Pagesize { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }
        public Author[] Authors { get; set; }

        public DateTime BookTaken { get; set; }
        public DateTime ReturnedBook { get; set; }

    }
}
