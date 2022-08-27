using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class TblAutor
    {
        public TblAutor()
        {
            TblBooks = new HashSet<TblBook>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<TblBook> TblBooks { get; set; }
    }
}
