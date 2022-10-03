using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PasswordManager.Contracts.Database;

[Table("tbl_users", Schema = "public")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; }

    [Required]
    [MaxLength(150)]
    [Column("email")]
    public string Email { get; set; }

    [Required]
    [MaxLength(512)]
    [Column("password")]
    public string Password { get; set; }

    [Required]
    [MaxLength(512)]
    [Column("password_salt")]
    public string PasswordSalt { get; set; }

    [InverseProperty("User")]
    public  virtual IEnumerable<Password> Passwords { get; set; }
}