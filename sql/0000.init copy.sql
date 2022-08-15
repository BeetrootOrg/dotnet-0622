CREATE DATABASE internet_shop;

CREATE TABLE IF NOT EXISTS tbl_products (
	id SERIAL PRIMARY KEY,
	name VARCHAR(100) NOT NULL,
	price MONEY NOT NULL,
	category VARCHAR(100) NOT NULL
);


ALTER TABLE IF EXISTS tbl_products
ADD IF NOT EXISTS quantity INTEGER NOT NULL CONSTRAINT default_quantity DEFAULT 0;
ALTER TABLE IF EXISTS tbl_products ALTER quantity DROP DEFAULT;
ALTER TABLE IF EXISTS tbl_products DROP IF EXISTS quantity;