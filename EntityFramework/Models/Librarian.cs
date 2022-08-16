using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

[Table("tbl_librarians", Schema = "public")]
class Librarian
{   
    [Key]
    [Column("librarian_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LibrarianId { get; set; }

    [Column("librarian_name")]
    [Required]
    [MaxLength(255)]
    public string LibrarianName { get; set; }
}
// CREATE TABLE IF NOT EXISTS tbl_librarians (
// 	librarian_id SERIAL PRIMARY KEY,
// 	librarian_name VARCHAR(255) NOT NULL
// );