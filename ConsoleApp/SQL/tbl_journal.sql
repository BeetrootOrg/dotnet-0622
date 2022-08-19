CREATE TABLE IF NOT EXISTS tbl_journal(
    id SERIAL PRIMARY KEY,
    book INTEGER NOT NULL REFERENCES tbl_books(id),
    customer INTEGER NOT NULL REFERENCES tbl_customers(id),
    book_taken_on DATE NOT NULL
);