using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblRent
    {
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public DateTime HandOver { get; set; }
        public DateTime? Returned { get; set; }

        public virtual TblBook Book { get; set; }
        public virtual TblReader Customer { get; set; }
    }
}
