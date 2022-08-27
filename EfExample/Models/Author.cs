using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_authors", Schema = "public")]
public class Author
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; init; }

    [Column("first_name")]
    [Required]
    [MaxLength(100)]
    public string FirstName { get; init; }

    [Column("last_name")]
    [Required]
    [MaxLength(100)]
    public string LastName { get; init; }
}
