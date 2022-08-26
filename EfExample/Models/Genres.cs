using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_genres", Schema = "public")]
public class Genres
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("genre")]
	[Required]
	[MaxLength(100)]
	public string Genre { get; set; }
}