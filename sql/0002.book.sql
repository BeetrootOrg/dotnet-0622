CREATE TABLE IF NOT EXISTS tbl_books (
	id SERIAL PRIMARY KEY,
	book_title VARCHAR(500) NOT NULL,
	book_year VARCHAR(4) NOT NULL,
	book_genre VARCHAR(255) NOT NULL,
	book_author INTEGER REFERENCES tbl_authors(id)
);