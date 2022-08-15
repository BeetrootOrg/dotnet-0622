using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblReceipt
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }

        public virtual TblCustomer Customer { get; set; }
        public virtual TblEmployee Employee { get; set; }
    }
}
