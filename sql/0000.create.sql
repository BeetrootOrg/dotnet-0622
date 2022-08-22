CREATE TABLE IF NOT EXISTS tbl_customers(
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_authors(
	id SERIAL PRIMARY KEY,
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_genres(
	id SERIAL PRIMARY KEY,
	genre VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_books(
	id SERIAL PRIMARY KEY,
	title VARCHAR(200) NOT NULL,
	total INT NOT NULL,
	author_id INT REFERENCES tbl_authors(id),
	genre_id INT NOT NULL REFERENCES tbl_genres(id),
	year SMALLINT
);

CREATE TABLE IF NOT EXISTS tbl_rents(
	book_id INT NOT NULL REFERENCES tbl_books(id),
	customer_id INT NOT NULL REFERENCES tbl_customers(id),
	rented_at TIMESTAMP NOT NULL,
	returned_at TIMESTAMP
);
