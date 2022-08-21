using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Models;

[Table("tbl_books", Schema = "public")]
public class Book
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Column("name")]
    [Required]
    [MaxLength(50)]
    public string Name {get;set;}

    [Column("author_id")]
    public int AuthorId {get;set;}

    [Column("genere")]
    [Required]
    [MaxLength(50)]
    public string Genre {get;set;}

    [Column("year_of_publication")]
    [Required]
    [MaxLength(4)]
    public string YearOfPublication {get;set;}

    [Column("count")]
    [Required]
    public int Count {get;set;}
}