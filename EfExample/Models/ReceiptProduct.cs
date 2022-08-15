using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample.Models;

[Table("tbl_receipts_products", Schema = "public")]
public class ReceiptProduct
{
	[Column("receipt_id")]
	public int ReceiptId { get; set; }

	public virtual Receipt Receipt { get; set; }

	[Column("product_id")]
	public int ProductId { get; set; }

	public virtual Product Product { get; set; }
}