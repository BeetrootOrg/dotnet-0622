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
    [MaxLength(500)]
    public string BookTitle { get; set; }

    [Column("book_genre")]
    [Required]
    [MaxLength(255)]
    public string BookGenre { get; set; }

    [Column("book_year")]
    [Required]
    [MaxLength(4)]
    public string BookYear { get; set; }

    [Column("book_author")]
    public int BookAuthor { get; set; }
}