CREATE TABLE IF NOT EXISTS tbl_authors (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_customers (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_books (
	id SERIAL PRIMARY KEY,
	title VARCHAR(255) NOT NULL,
	author_id INT NOT NULL REFERENCES tbl_authors(id),
	deleted BOOL DEFAULT FALSE
);

CREATE TABLE IF NOT EXISTS tbl_books_store (
	book_id INT NOT NULL REFERENCES tbl_books(id),
	instock BOOL DEFAULT TRUE
);

CREATE TABLE IF NOT EXISTS tbl_main_journal (
	id SERIAL PRIMARY KEY,
	customer_id INT REFERENCES tbl_customers(id),
	book_id INT REFERENCES tbl_books(id),
	taken_date DATE NOT NULL DEFAULT CURRENT_DATE, 
	return_date DATE
);