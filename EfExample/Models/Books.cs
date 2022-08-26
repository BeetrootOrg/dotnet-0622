using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_books", Schema = "public")]
public class Books
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("book_title")]
	[Required]
	[MaxLength(255)]
	public string BookTitle { get; set; }

	[Column("book_publication")]
	public short BookPublication { get; set; }
	
	[Column("book_total")]
	[Required]
	public int BookTotal { get; set; }

	[Column("author_id")]
	[Required]
	public int AuthorId { get; set; }

	[Column("genre_id")]
	[Required]
	public int GenreId { get; set; }
}