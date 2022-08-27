CREATE TABLE IF NOT EXISTS tbl_readers(
	id SERIAL PRIMARY KEY,
	reader_first_name VARCHAR(150) NOT NULL,
	reader_last_name VARCHAR(150) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_authors(
	id SERIAL PRIMARY KEY,
	author_first_name VARCHAR(150) NOT NULL,
	author_last_name VARCHAR(150) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_genres(
	id SERIAL PRIMARY KEY,
	genre VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_books(
	id SERIAL PRIMARY KEY,
	book_name VARCHAR(250) NOT NULL,
	amount INT NOT NULL,
	status BOOLEAN NOT NULL,
	author_id INT REFERENCES tbl_authors(id),
	genre_id INT NOT NULL REFERENCES tbl_genres(id),
	year SMALLINT
);

CREATE TABLE IF NOT EXISTS tbl_rents(
	book_id INT NOT NULL REFERENCES tbl_books(id),
	customer_id INT NOT NULL REFERENCES tbl_readers(id),
	hand_over TIMESTAMP NOT NULL,
	returned TIMESTAMP
);