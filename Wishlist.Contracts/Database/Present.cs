using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wishlist.Contracts.Database;

[Table("tbl_presents", Schema = "public")]
public class Present
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; }

    [MaxLength(500)]
    [Column("comment")]
    public string Comment { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("booked_at")]
    public DateTime? BookedAt { get; set; }

    [ForeignKey(nameof(Wishlist))]
    [Column("wishlist_id")]
    public int WishlistId { get; set; }

    public virtual Wishlist Wishlist { get; set; }
}