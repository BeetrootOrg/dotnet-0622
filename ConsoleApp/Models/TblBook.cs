using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public partial class TblBook
    {
        public TblBook()
        {
            TblTransactions = new HashSet<TblTransaction>();
        }

        public int Id { get; set; }
        public string Tittle { get; set; } = null!;
        public int Author { get; set; }
        public int Genre { get; set; }
        public int Year { get; set; }
        public int InitialQuantity { get; set; }

        public virtual TblAuthor AuthorNavigation { get; set; } = null!;
        public virtual TblGenre GenreNavigation { get; set; } = null!;
        public virtual ICollection<TblTransaction> TblTransactions { get; set; }
    }
}
