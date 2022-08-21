CREATE TABLE IF NOT EXISTS tbl_books (
    id SERIAL PRIMARY KEY,
    book_title VARCHAR(255) NOT NULL,
    book_genre VARCHAR(100) NOT NULL,
    book_publication SMALLINT NOT NULL,
    book_language VARCHAR(50) NOT NULL,
    author_id INT NOT NULL REFERENCES tbl_authors(id)
)