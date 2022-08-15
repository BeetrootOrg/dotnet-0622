using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_products", Schema = "public")]
public class Product
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("name")]
	[Required]
	[MaxLength(500)]
	public string Name { get; set; }

	[Column("price")]
	public decimal Price { get; set; }

	public virtual IEnumerable<Receipt> Receipts { get; set; }
}