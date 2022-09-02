using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_authors", Schema = "public")]
public class Author
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

    [Column("date_of_birth")]
    [Required]
    [MaxLength(4)]
    public string DateOfBirth { get; set; }

    [Column("date_of_death")]
    [Required]
    [MaxLength(4)]
    public string DateOfDeath { get; set; }

    [Column("biography")]
    public string Biography { get; set; }
}