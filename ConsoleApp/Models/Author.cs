using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Models;

[Table("tbl_authors", Schema = "public")]
public class Author
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}
    
    [Column("first_name")]
    [Required]
    [MaxLength(50)]
    public string FirstName {get;set;}

    [Column("last_name")]
    [Required]
    [MaxLength(50)]
    public string LastName {get;set;}
}