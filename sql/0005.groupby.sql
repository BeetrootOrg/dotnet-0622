SELECT r.id AS receipt_id,
	SUM(p.price)
FROM tbl_receipts r
	JOIN tbl_receipts_products rp ON r.id = rp.receipt_id
	JOIN tbl_products p ON rp.product_id = p.id
GROUP BY r.id
ORDER BY r.id;