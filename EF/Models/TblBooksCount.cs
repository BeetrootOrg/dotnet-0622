using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class TblBooksCount
    {
        public int? BookId { get; set; }
        public int BookCount { get; set; }

        public virtual TblBook? Book { get; set; }
    }
}
