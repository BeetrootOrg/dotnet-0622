using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_books_store", Schema = "public")]
public class BookStore
{
	[Column("book_id")]
	[Required]
	public int BookId { get; set; }    

	[Column("instock")]
	public bool InStock { get; set; }


}

