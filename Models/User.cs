using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetTest.Models
{
    [Table("tbl_users", Schema = "public")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("username")]
        [Required]
        public string Username { get; set; }

        [Column("password")]
        [Required]
        public string Password { get; set; }
    }
}