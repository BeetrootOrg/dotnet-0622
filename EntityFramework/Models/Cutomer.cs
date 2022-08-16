using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

[Table("tbl_cutomers", Schema = "public")]
class Cutomer
{
    [Key]
    [Column("cutomers_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CutomerId { get; set; }

    [Column("cutomers_name")]
    [Required]
    [MaxLength(255)]
    public string CutomerName { get; set; }

    [Column("cutomers_address")]
    [Required]
    [MaxLength(255)]
    public string CutomerAddress { get; set; }

    [Column("cutomers_phone")]
    [Required]
    [MaxLength(255)]
    public string CutomerPhone { get; set; }
}

// CREATE TABLE IF NOT EXISTS tbl_cutomers (
// 	cutomers_id SERIAL PRIMARY KEY,
// 	cutomers_name VARCHAR(255) NOT NULL,
// 	cutomers_address VARCHAR(255) NOT NULL,
// 	cutomers_phone VARCHAR(50) NOT NULL
// );