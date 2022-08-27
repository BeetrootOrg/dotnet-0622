using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class TblLibrary
    {
        public int? CustomerId { get; set; }
        public int? BookId { get; set; }
        public DateOnly BookTaken { get; set; }
        public DateOnly? BookReturned { get; set; }

        public virtual TblBook? Book { get; set; }
        public virtual TblCustomer? Customer { get; set; }
    }
}
