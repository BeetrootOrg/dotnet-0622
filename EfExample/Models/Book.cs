using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EfExample.Models;

[Table("tbl_books", Schema = "public")]
public class Book
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("title")]
	[Required]
	[MaxLength(255)]
	public string Title { get; set; }

	[Column("author_id")]
	[Required]
	public int AuthorId { get; set; }    

	[Column("deleted")]
	public bool Deleted { get; set; }

    
	//public virtual IEnumerable<Receipt> Receipts { get; set; }
}