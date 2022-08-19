CREATE TABLE IF NOT EXISTS tbl_history_entries (
	id SERIAL PRIMARY KEY,	
	customer INTEGER REFERENCES tbl_customer(id) NOT NULL,
	book INTEGER REFERENCES tbl_books(id) NOT NULL,
	date_of_book_borrow DATE NOT NULL
);