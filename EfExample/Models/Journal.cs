using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_journal", Schema = "public")]
public class Journal
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; init; }

    [Column("book")]
    [Required]
    public string Book { get; init; }

    [Column("Customer")]
    [Required]
    public string Customer { get; init; }

    [Column("book_taken_on")]
    [Required]
    public DateTime BookTakenOn { get; set; }
}

