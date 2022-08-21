CREATE TABLE IF NOT EXISTS tbl_autors(
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_books(
    id SERIAL PRIMARY KEY,
    autor_id INT REFERENCES tbl_autors(id),
    book_name VARCHAR(255) NOT NULL,
    book_genre VARCHAR(255) NOT NULL,
    book_year DATE NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_books_count(
    book_id INT REFERENCES tbl_books(id),
    book_count INTEGER NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS tbl_customers(
    id SERIAL PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_library(
    customer_id INT REFERENCES tbl_customers(id),
    book_id INT REFERENCES tbl_books(id),
    book_taken DATE NOT NULL DEFAULT CURRENT_DATE,
    book_returned DATE
);