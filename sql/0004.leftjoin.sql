SELECT r.id AS receipt_id,
	c.first_name AS customer_first_name,
	c.last_name AS customer_last_name,
	e.first_name AS employee_first_name,
	e.last_name AS employee_last_name,
	p.name AS product_name,
	p.price AS product_price
FROM tbl_receipts r
	LEFT JOIN tbl_customers c ON r.customer_id = c.id
	LEFT JOIN tbl_employees e ON r.employee_id = e.id
	JOIN tbl_receipts_products rp ON r.id = rp.receipt_id
	JOIN tbl_products p ON rp.product_id = p.id;