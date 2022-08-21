using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ConsoleApp.Models;

[Table("tbl_borrowing_history", Schema = "public")]
public class BorrowingHistory
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}
    
    [Column("book_id")]
    [Required]
    public int BookId {get;set;}

    [Column("customer_id")]
    [Required]
    public int CustomerId {get;set;}

    [Column("date_of_borrowing")]
    [Required]
    public DateTime DateOfBorrowing {get;set;}
    
    [Column("date_of_returning")]
    public DateTime DateOfReturning {get;set;}
}