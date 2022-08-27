using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblBook
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
        public int? AuthorId { get; set; }
        public int GenreId { get; set; }
        public short? Year { get; set; }

        public virtual TblAuthor Author { get; set; }
        public virtual TblGenre Genre { get; set; }
    }
}
