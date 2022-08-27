using System;
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
    [MaxLength(100)]
    public string Title { get; init; }
    public string WrittenBy { get; init; }

    [Column("genre")]
    [Required]
    [MaxLength(50)]
    public string Genre { get; init; }

    [Column("publishing_date")]
    [Required]
    public DateTime PublishingDate { get; init; }

    [Column("quantity")]
    [Required]
    public int Quantity { get; init; }
}
