using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PasswordManager.Contracts.Database;

[Table("tbl_passwords", Schema = "public")]
public class Password
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(500)]
    [Column("website_name")]
    public string WebsiteName { get; set; }

    [Required]
    [MaxLength(512)]
    [Column("password")]
    public string EncryptedPassword { get; set; }

    [Required]
    [MaxLength(512)]
    [Column("password_salt")]
    public string EncryptedPasswordSalt { get; set; }

    [ForeignKey(nameof(User))]
    [Column("user_id")]
    public int UserId { get; set; }

    public virtual User User { get; set; }
}