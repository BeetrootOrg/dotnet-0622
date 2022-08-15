using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblEmployee
    {
        public TblEmployee()
        {
            TblReceipts = new HashSet<TblReceipt>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PositionId { get; set; }
        public decimal Salary { get; set; }

        public virtual TblPosition Position { get; set; }
        public virtual ICollection<TblReceipt> TblReceipts { get; set; }
    }
}
