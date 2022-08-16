using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

[Table("tbl_publishers", Schema = "public")]
class Publisher
{   
    [Key]
    [Column("publisher_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PublisherId { get; set; }

    [Column("publisher_name")]
    [Required]
    [MaxLength(255)]
    public string PublisherName { get; set; }

}

// CREATE TABLE IF NOT EXISTS tbl_publishers (
// 	publisher_id SERIAL PRIMARY KEY,
// 	publisher_name VARCHAR(255) NOT NULL
// );