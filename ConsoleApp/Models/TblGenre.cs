using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class TblGenre
    {
        public TblGenre()
        {
            TblBooks = new HashSet<TblBook>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TblBook> TblBooks { get; set; }
    }
}
