using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class ViewReceipt
    {
        public int? ReceiptId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
    }
}
