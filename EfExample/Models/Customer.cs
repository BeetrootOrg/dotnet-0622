using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_customer", Schema = "public")]
public class Customer
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [Column("first_name")]
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; }

    [Column("last_name")]
    [Required]
    [MaxLength(255)]
    public string LastName { get; set; }

    [Column("phone_number")]
    [MaxLength(25)]
    public string PhoneNumber { get; set; }

    [Column("email")]
    [MaxLength(255)]
    public string Email { get; set; }
}