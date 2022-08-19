CREATE TABLE IF NOT EXISTS tbl_books (
    id SERIAL PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    written_by INTEGER REFERENCES tbl_authors(id),
    genre VARCHAR(50) NOT NULL,
    publishing_date DATE NOT NULL,
    quantity INTEGER NOT NULL
);