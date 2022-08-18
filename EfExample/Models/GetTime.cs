using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_book_gets", Schema = "public")]
public class GetTime
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("get_time")]
	[Required]
	public DateTime Date { get; init; }

    [Column("customer_id")]
	[Required]
	public int? CustomerId { get; set; }

	public virtual Customer Customer { get; set; }

	[Column("books_id")]
	[Required]
	public int? BookId { get; set; }

	public virtual Book Book { get; set; }
}