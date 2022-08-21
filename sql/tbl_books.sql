CREATE TABLE IF NOT EXISTS tbl_books(
    ID SERIAL PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    authhor_id INTEGER NOT NULL REFERENCES tbl_authors(id),
    publishing_year DATE,
    publishing_house VARCHAR(100),
    city VARCHAR(100),
    books_number INTEGER NOT NULL DEFAULT 0 CHECK(books_number > -1)
    );