using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_positions", Schema = "public")]
public class Position
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("name")]
	[Required]
	[MaxLength(50)]
	public string Name { get; init; }

	public virtual IEnumerable<Employee> Employees { get; set; }
}