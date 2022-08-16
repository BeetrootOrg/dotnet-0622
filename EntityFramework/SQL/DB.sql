CREATE TABLE IF NOT EXISTS tbl_book (
	book_id SERIAL PRIMARY KEY,
	book_name VARCHAR(50) NOT NULL,
	book_isbn VARCHAR(50) NOT NULL,
	book_edition INTEGER(20) NOT NULL,
	author_id INT NOT NULL REFERENCES tbl_authors(author_id),
	publisher_id INT NOT NULL REFERENCES tbl_publishers(publisher_id)
);
CREATE TABLE IF NOT EXISTS tbl_authors (
	author_id SERIAL PRIMARY KEY,
	author_name VARCHAR(255) NOT NULL
);
CREATE TABLE IF NOT EXISTS tbl_publishers (
	publisher_id SERIAL PRIMARY KEY,
	publisher_name VARCHAR(255) NOT NULL
);
CREATE TABLE IF NOT EXISTS tbl_loans (
	loan_date DATETIME NOT NULL,
	loans_is_active BOOLEAN NOT NULL,
	custumer_id INT NOT NULL REFERENCES tbl_customers(customer_id),
	book_id INT NOT NULL REFERENCES tbl_books(book_id),
	librarian_id INT NOT NULL REFERENCES tbl_librarians(librarian_id)
);
CREATE TABLE IF NOT EXISTS tbl_cutomers (
	cutomers_id SERIAL PRIMARY KEY,
	cutomers_name VARCHAR(255) NOT NULL,
	cutomers_address VARCHAR(255) NOT NULL,
	cutomers_phone VARCHAR(50) NOT NULL
);
CREATE TABLE IF NOT EXISTS tbl_librarians (
	librarian_id SERIAL PRIMARY KEY,
	librarian_name VARCHAR(255) NOT NULL
);