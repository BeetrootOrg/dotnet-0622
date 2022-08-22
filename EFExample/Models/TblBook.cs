using System;
using System.Collections.Generic;

namespace EFExample.Models
{
    public partial class TblBook
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int AuthorId { get; set; }
        public string Genre { get; set; } = null!;
        public int YearOfPublication { get; set; }
        public int Count { get; set; }

        public virtual TblAuthor Author { get; set; } = null!;
    }
}
