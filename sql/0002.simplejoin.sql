SELECT r.id AS receipt_id,
	c.first_name AS customer_first_name,
	c.last_name AS customer_last_name,
	e.first_name AS employee_first_name,
	e.last_name AS employee_last_name
FROM tbl_receipts r
	JOIN tbl_customers c ON r.customer_id = c.id
	JOIN tbl_employees e ON r.employee_id = e.id;