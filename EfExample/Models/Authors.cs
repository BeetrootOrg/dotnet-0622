using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_tbl_authors", Schema = "public")]
public class Authors
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
}