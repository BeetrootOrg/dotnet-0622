CREATE TABLE IF NOT EXISTS tbl_history (
    book_id INTEGER NOT NULL REFERENCES tbl_books(id),
    customer_id INTEGER NOT NULL REFERENCES tbl_customers(id),
    took_book DATE NOT NULL,
    gave_book DATE
);