using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_history", Schema = "public")]
public class History
{
	[Column("book_id")]
	[Required]
	public int BookId { get; set; }

	[Column("customer_id")]
	[Required]
	public int CustomerId { get; set; }

	[Column("took_book")]
	[Required]
	public DateTime TookBook { get; set; }

	[Column("gave_book")]
	public DateTime GaveBook { get; set; }
	
}