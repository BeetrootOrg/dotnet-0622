using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

[Table("tbl_customers", Schema = "public")]
class Customer
{
    [Key]
    [Column("customer_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CustomerId { get; set; }

    [Column("customer_name")]
    [Required]
    [MaxLength(255)]
    public string CustomerName { get; set; }

    [Column("customer_address")]
    [Required]
    [MaxLength(255)]
    public string CustomerAddress { get; set; }

    [Column("customer_phone")]
    [Required]
    [MaxLength(50)]
    public string CustomerPhone { get; set; }
}
