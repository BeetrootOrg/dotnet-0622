using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persons.Web.Models;

[Table("tbl_persons", Schema = "public")]
public class Person
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("first_name")]
    [DisplayName("First Name")]
    public string? FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("last_name")]
    [DisplayName("Last Name")]
    public string? LastName { get; set; }

    [Column("age")]
    [DisplayName("Age")]
    public short Age { get; set; }

    [Column("gender")]
    [DisplayName("Gender")]
    public char Gender { get; set; }

    [MaxLength(255)]
    [Column("address")]
    [DisplayName("Address")]
    public string? Address { get; set; }
}