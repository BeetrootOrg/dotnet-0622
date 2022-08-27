using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblGenre
    {
        public TblGenre()
        {
            TblBooks = new HashSet<TblBook>();
        }

        public int Id { get; set; }
        public string Genre { get; set; }

        public virtual ICollection<TblBook> TblBooks { get; set; }
    }
}
