using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_receipts", Schema = "public")]
public class Receipt
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("customer_id")]
	public int? CustomerId { get; set; }

	[Column("employee_id")]
	public int? EmployeeId { get; set; }

	public virtual IEnumerable<Product> Products { get; set; }
	public virtual Customer Customer { get; set; }
	public virtual Employee Employee { get; set; }
}