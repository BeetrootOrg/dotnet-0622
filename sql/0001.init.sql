CREATE TABLE IF NOT EXISTS tbl_authors (
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_books (
    id SERIAL PRIMARY KEY,
    book_title VARCHAR(255) NOT NULL,
    book_publication SMALLINT,
    book_total INT NOT NULL,
    author_id INT NOT NULL REFERENCES tbl_authors(id),
    genre_id INT NOT NULL REFERENCES tbl_genres(id)
);

CREATE TABLE IF NOT EXISTS tbl_customers (
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_history (
    book_id INTEGER NOT NULL REFERENCES tbl_books(id),
    customer_id INTEGER NOT NULL REFERENCES tbl_customers(id),
    took_book DATE NOT NULL,
    gave_book DATE
);

CREATE TABLE IF NOT EXISTS tbl_genres(
	id SERIAL PRIMARY KEY,
	genre VARCHAR(100) NOT NULL
);