CREATE TABLE IF NOT EXISTS tbl_customers (
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_authors (
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_books (
	id SERIAL PRIMARY KEY,
    book_title VARCHAR(50) NOT NULL,
	book_genre VARCHAR(50) NOT NULL,
	book_publication_year SMALLINT NOT NULL,
	autors_id INT NOT NULL REFERENCES tbl_authors(id)
);

CREATE TABLE IF NOT EXISTS tbl_book_gets (
	id SERIAL PRIMARY KEY,
    get_time DATE NOT NULL,
	customer_id INT REFERENCES tbl_customers(id) NOT NULL,
	books_id INT REFERENCES tbl_books(id) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_book_returns (
	id SERIAL PRIMARY KEY,
    return_time DATE,
	customer_id INT REFERENCES tbl_customers(id) NOT NULL,
	books_id INT REFERENCES tbl_books(id) NOT NULL
);