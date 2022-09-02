using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_history_entries", Schema = "public")]
public class HistoryEntry
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [Column("book")]
    [Required]
    public int Book { get; set; }

    [Column("customer")]
    [Required]
    public int Customer { get; set; }

    [Column("date_of_book_borrow")]
    [Required]
    public DateTime DateOfBookBorrow { get; set; }
}