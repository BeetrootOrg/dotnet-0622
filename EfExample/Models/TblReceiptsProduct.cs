using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblReceiptsProduct
    {
        public int ReceiptId { get; set; }
        public int ProductId { get; set; }

        public virtual TblProduct Product { get; set; }
        public virtual TblReceipt Receipt { get; set; }
    }
}
