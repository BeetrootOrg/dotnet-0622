using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class TblCustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
