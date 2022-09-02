using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_books_ammounts", Schema = "public")]
public class BookAmount
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [Column("book")]
    [Required]
    public int Book { get; set; }

    [Column("amount")]
    [Required]
    public int Amount { get; set; }
}