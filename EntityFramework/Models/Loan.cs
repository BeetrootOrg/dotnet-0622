using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

[Table("tbl_loans", Schema = "public")]
class Loan
{
    [Column("loan_date")]
    [Required]
    public DateTime LoanDate { get; set; }

    [Column("loans_is_active")]
    [Required]
    [MaxLength(50)]
    public bool BookName { get; set; }

    [Column("book_isbn")]
    [Required]
    [MaxLength(50)]
    public string LoanIsActive { get; set; }

    [Column("custumer_id")]
    public Customer CustomerId { get; set; }

    [Column("book_id")]
    public Book BookId { get; set; }

    [Column("librarian_id")]
    public Librarian LibrarianId { get; set; }
}
