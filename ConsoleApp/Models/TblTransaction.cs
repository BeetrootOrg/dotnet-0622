using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class TblTransaction
    {
        public int Id { get; set; }
        public int Book { get; set; }
        public int Reader { get; set; }
        public short Quantity { get; set; }
        public DateTime? Time { get; set; }

        public virtual TblBook BookNavigation { get; set; } = null!;
        public virtual TblReader ReaderNavigation { get; set; } = null!;
    }
}
