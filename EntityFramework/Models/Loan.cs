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
}

// CREATE TABLE IF NOT EXISTS tbl_loans (
// 	loan_date DATETIME NOT NULL,
// 	loans_is_active BOOLEAN NOT NULL,

// 	custumer_id INT NOT NULL REFERENCES tbl_customers(customer_id),
// 	book_id INT NOT NULL REFERENCES tbl_books(book_id),
// 	librarian_id INT NOT NULL REFERENCES tbl_librarians(librarian_id)
// );