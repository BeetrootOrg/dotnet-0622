using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_main_journal", Schema = "public")]
public class MainJournal
{
	[Key]
	[Column("id")]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; init; }

	[Column("customer_id")]
	[Required]
	public int CustomerId { get; set; }    


    [Column("book_id")]
	[Required]
	public int BookId { get; set; }    


    [Column("taken_data")]
    [Required]
    public string TakenData{ get; set; }

    [Column("return_data")]
    [Required]
    public string ReturnData{ get; set; }

	//public virtual IEnumerable<Receipt> Receipts { get; set; }
}

