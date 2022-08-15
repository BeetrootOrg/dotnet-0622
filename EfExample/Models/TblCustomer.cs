using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblReceipts = new HashSet<TblReceipt>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<TblReceipt> TblReceipts { get; set; }
    }
}
