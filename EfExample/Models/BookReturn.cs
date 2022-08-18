using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfExample.Models
{
    [Table("tbl_book_returns", Schema = "public")]
    public class BookReturn
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        [Column("return_time")]
        public DateTime Date { get; init; }

        [Column("book_gets")]
        [Required]
        public int? GetTimeId { get; set; }

        public virtual GetTime GetTime { get; set; }

        [Column("customer_id")]
        [Required]
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Column("books_id")]
        [Required]
        public int? BookId { get; set; }

        public virtual Book Book { get; set; }


    }
}
