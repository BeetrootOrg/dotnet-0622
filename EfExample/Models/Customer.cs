using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_customers", Schema = "public")]
public class Customer
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("name")]
	[Required]
	[MaxLength(50)]
	public string Name { get; set; }

	[Column("last_name")]
	[Required]
	[MaxLength(50)]
	public string LastName { get; set; }

	//public virtual IEnumerable<Receipt> Receipts { get; set; }
}

