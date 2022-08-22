using System;
using System.Collections.Generic;

namespace EFExample.Models
{
    public partial class TblBorrowingHistory
    {
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public DateOnly DateOfBorrowing { get; set; }
        public DateOnly? DateOfReturning { get; set; }

        public virtual TblBook Book { get; set; } = null!;
        public virtual TblCustomer Customer { get; set; } = null!;
    }
}
