using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_employees", Schema = "public")]
public class Employee
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("first_name")]
	[Required]
	[MaxLength(50)]
	public string FirstName { get; set; }

	[Column("last_name")]
	[Required]
	[MaxLength(50)]
	public string LastName { get; set; }

	[Column("position_id")]
	public int PositionId { get; set; }

	public Position Position { get; set; }

	[Column("salary")]
	public decimal Salary { get; set; }

	public virtual IEnumerable<Receipt> Receipts { get; set; }
}