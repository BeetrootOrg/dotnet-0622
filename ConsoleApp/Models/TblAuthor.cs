using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class TblAuthor
    {
        public TblAuthor()
        {
            TblBooks = new HashSet<TblBook>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<TblBook> TblBooks { get; set; }
    }
}
