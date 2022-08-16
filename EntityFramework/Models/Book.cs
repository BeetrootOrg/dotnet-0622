using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

[Table("tbl_book", Schema = "public")]
class Book
{   
    [Key]
    [Column("book_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("book_name")]
    [Required]
    [MaxLength(50)]
    public string BookName { get; set; }
    
    [Column("book_isbn")]
    [Required]
    [MaxLength(50)]
    public string BookIsbn { get; set; }

    [Column("book_edition")]
    [Required]
    [MaxLength(20)]
    public int BookEdition { get; set; }

    [Column("author_id")]
    public Author AuthorId { get; set; }

    [Column("publisher_id")]
    public Publisher PublisherId { get; set; }
}
