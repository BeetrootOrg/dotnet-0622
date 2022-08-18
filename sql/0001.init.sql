CREATE TABLE IF NOT EXISTS tbl_positions (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_employees (
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	position_id INT NOT NULL REFERENCES tbl_positions(id),
	salary MONEY NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_customers (
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_receipts (
	id SERIAL PRIMARY KEY,
	customer_id INT REFERENCES tbl_customers(id),
	employee_id INT REFERENCES tbl_employees(id)
);

CREATE TABLE IF NOT EXISTS tbl_products (
	id SERIAL PRIMARY KEY,
	name VARCHAR(500) NOT NULL,
	price MONEY NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_receipts_products (
	receipt_id INT NOT NULL REFERENCES tbl_receipts(id),
	product_id INT NOT NULL REFERENCES tbl_products(id)
);