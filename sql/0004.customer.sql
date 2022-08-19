CREATE TABLE IF NOT EXISTS tbl_customer (
	id SERIAL PRIMARY KEY,	
	first_name VARCHAR(255) NOT NULL,
	last_name VARCHAR(255) NOT NULL,
	phone_number VARCHAR(25),
	email VARCHAR(255)
);