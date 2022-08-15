using System;
using System.Collections.Generic;

namespace EfExample.Models
{
    public partial class TblPosition
    {
        public TblPosition()
        {
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
