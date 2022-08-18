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

	[Column("book_title")]
	[Required]
	[MaxLength(50)]
	public string BookTitle { get; set; }

	[Column("book_genre")]
    [Required]
    [MaxLength(50)]
	public string Book_Genre { get; set; }
    
	[Column("book_publication_year")]
    [Required]
	public short BookPublicationYear { get; set; }

	[Column("authors_id")]
	[Required]
	public int? AuthorId { get; set; }
}