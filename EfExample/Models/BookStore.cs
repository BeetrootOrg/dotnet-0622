using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EfExample.Models;


[Table("tbl_books_store", Schema = "public")]
[Keyless]
public class BookStore
{
	[Column("book_id")]
	[Required]
	public int BookId { get; set; }    

	[Column("instock")]
	public bool InStock { get; set; }
}

