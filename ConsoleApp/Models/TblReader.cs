using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class TblReader
    {
        public TblReader()
        {
            TblTransactions = new HashSet<TblTransaction>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<TblTransaction> TblTransactions { get; set; }
    }
}
