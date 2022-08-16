using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

[Table("tbl_authors", Schema = "public")]
class Author
{   
    [Key]
    [Column("author_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorId { get; set; }

    [Column("author_name")]
    [Required]
    [MaxLength(255)]
    public string AuthorName { get; set; }
}
