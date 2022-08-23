using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class TblBook
    {
        public int Id { get; set; }
        public int? AutorId { get; set; }
        public string BookName { get; set; } = null!;
        public string BookGenre { get; set; } = null!;
        public DateOnly BookYear { get; set; }

        public virtual TblAutor? Autor { get; set; }
    }
}
