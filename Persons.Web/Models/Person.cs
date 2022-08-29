using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persons.Web.Models;

[Table("tbl_persons", Schema = "public")]
public class Person
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	[Column("id")]
	public int Id { get; set; }

	[Required]
	[MaxLength(100)]
	[Column("first_name")]
	public string? FirstName { get; set; }

	[Required]
	[MaxLength(100)]
	[Column("last_name")]
	public string? LastName { get; set; }

	[Column("age")]
	public short Age { get; set; }

	[Column("gender")]
	public char Gender { get; set; }

	[MaxLength(255)]
	[Column("address")]
	public string? Address { get; set; }
}