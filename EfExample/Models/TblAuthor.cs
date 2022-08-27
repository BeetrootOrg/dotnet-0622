using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblAuthor
    {
        public TblAuthor()
        {
            TblBooks = new HashSet<TblBook>();
        }

        public int Id { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }

        public virtual ICollection<TblBook> TblBooks { get; set; }
    }
}
